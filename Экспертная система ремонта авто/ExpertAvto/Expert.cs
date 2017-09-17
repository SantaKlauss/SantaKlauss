using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAvto
{
    class Expert
    {
        // Постоянаая база 
        List<SQuestion> questions;
        List<SResponse> responses;
        // Временная база 
        List<int> donequest;
        List<SQuestion> Tquestions;
        List<SResponse> Tresponses;
        int step;

        private SqlCeConnection sqlConnectionDB;
        private SqlCeConnection sqlConnectionKB;

        public Expert()
        { // конструктор
            questions = new List<SQuestion>();
            responses = new List<SResponse>();

            sqlConnectionDB = new SqlCeConnection();
            sqlConnectionDB.ConnectionString = "Data Source = DB.sdf;Persist Security Info=False";
            sqlConnectionDB.Open();

            sqlConnectionKB = new SqlCeConnection();
            sqlConnectionKB.ConnectionString = "Data Source = KB.sdf;Persist Security Info=False";
            sqlConnectionKB.Open();

            //выполняем запрос
            SqlCeDataReader myReader = null;
            SqlCeCommand myCommand = new SqlCeCommand("SELECT * FROM Question",
                                                     sqlConnectionDB);
            myReader = myCommand.ExecuteReader();
            
            while (myReader.Read())
            {
                questions.Add(new SQuestion(int.Parse(myReader["id"].ToString()), myReader["question"].ToString()));
            }

            myReader = null;
            myCommand = new SqlCeCommand("SELECT * FROM Answer", sqlConnectionDB);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {          
                SqlCeDataReader myReaderIn = null;
                SqlCeCommand myCommandIn = new SqlCeCommand("SELECT * FROM QuestAnswers WHERE answer=" + myReader["id"].ToString(),
                                                         sqlConnectionDB);
                myReaderIn = myCommandIn.ExecuteReader();       
         
                List <int> quests = new List<int>();
                while (myReaderIn.Read())
                {
                    quests.Add(int.Parse(myReaderIn["question"].ToString()));
                }
                
                SResponse thisResponse = new SResponse();
                responses.Add(thisResponse);

                thisResponse.idQuest = quests;
                thisResponse.probability = float.Parse(myReader["startVer"].ToString());
               
                
                myReaderIn = null;
                myCommandIn = new SqlCeCommand("SELECT * FROM Answers WHERE id=" + myReader["kod"].ToString(),
                                                         sqlConnectionKB);
                myReaderIn = myCommandIn.ExecuteReader();   
                while (myReaderIn.Read())
                {
                    thisResponse.id = int.Parse(myReaderIn["id"].ToString());
                    thisResponse.response = myReaderIn["name"].ToString();
                    thisResponse.description = myReaderIn["description"].ToString();
                    thisResponse.image = myReaderIn["image"].ToString();
                }
            }          
                
        }


        
          public void newgame () 
          {
              // Старт новой игры
              donequest = new List<int>();
              Tquestions = new List<SQuestion>(questions);
              Tresponses = new List<SResponse>(responses);

              for (int i=0; i<Tresponses.Count; i++)
              {
                  Tresponses[i].idQuest.Reverse();
              }
              step = 0;
          }



          public int getQuestion () {
              // новый вопрос
              // Каждый новый вопрос берется у самого подходяешго на данный момент персонажа,
              // Таким образом, либо повысится вероятность того, что он и есть персонаж
              // либо полностью исключится (или понизится?)
              int id;
              while (Tresponses[Tresponses.Count - 1].idQuest.Count > 0 && Tresponses[Tresponses.Count - 1].idQuest[Tresponses[Tresponses.Count - 1].idQuest.Count - 1] == -1) 
                  Tresponses[Tresponses.Count - 1].idQuest.RemoveAt(Tresponses [Tresponses.Count - 1].idQuest.Count-1);

              while (Tresponses[Tresponses.Count - 2].idQuest.Count >0 && Tresponses[Tresponses.Count - 2].idQuest[Tresponses [Tresponses.Count - 2].idQuest.Count - 1] ==-1) 
                        Tresponses [Tresponses.Count - 2].idQuest.RemoveAt(Tresponses [Tresponses.Count - 2].idQuest.Count-1);

              if (step>3)
              {
                  if (Tresponses [Tresponses.Count - 1].idQuest.Count ==0)
                  {
                      if (Tresponses [Tresponses.Count - 2].idQuest.Count!=0)
                      {
                          id=Tresponses [Tresponses.Count - 2].idQuest [Tresponses [Tresponses.Count - 2].idQuest.Count - 1];
                      }
                      else
                      { // если о обоих на данный момент самых вероятных ответов больше не осталось вопросов, и их вероятности раны, лбио почти одинаковы,
                          // то понимажем их вероятность и переходи к другим вопросам.
                          if (Tresponses [Tresponses.Count - 1].probability-Tresponses [Tresponses.Count - 2].probability<0.01 && havequestions ())
                          {
                              Tresponses [Tresponses.Count - 1].probability/=1.5;
                              Tresponses [Tresponses.Count - 2].probability/=1.5;
                              for (int i = Tresponses.Count - 1; i > 0; i--)
                              {
                                  for (int j = 0; j < i; j++)
                                  {
                                      if (Tresponses[j].probability > Tresponses[j + 1].probability)
                                      {
                                          Tresponses.Reverse(j, 2);
                                      }
                                         
                                  }
                              }
                              return getQuestion (); // Отсортировав в соотв.с новыми вероятностями, берем вопрос.
                          }
                          return - 1; // ответ - на данный момент самый вероянтый.Ответ не точный, но система делает вывод, что дальше спрашивать смысла нет
                      }
                  }
                  else
                  {
                      id=Tresponses [Tresponses.Count - 1].idQuest [Tresponses [Tresponses.Count - 1].idQuest.Count - 1];
                  }
              }
              else // первые три (?) вопроса берем для первоначальной сортировки воросов, самые общие вопросы, по мнению системы
              {
                  id = populatQuestion ();
              }
              step++;
              for (int i=0; i<Tquestions.Count; i++)
              {
                  if (Tquestions [i].id == id)
                  {
                      Console.WriteLine(Tquestions [i].question);
                      return id;
                  }
              }

              return 0;
          }


          public void setQuestion (int id, int q) // корректируем текущую базу в соответсвии с овтетом на вопрос
          {
              if (q==1)
              {
                  // У всех вариантов ответа, у которых есть даннный вопрос, повышаем вероятность
                  int k = 0; int ii=0;
                  for (int i=0; i<Tresponses.Count; i++)
                  {
                      if (findInVector (Tresponses [i].idQuest, id))
                      {
                          k++;
                          ii=i;
                          Tresponses [i].probability*=4;
                          for (int j=0; j<Tresponses [i].idQuest.Count; j++)
                          {
                              if (Tresponses [i].idQuest [j] ==id) Tresponses [i].idQuest [j] =-1;
                          }
                      }
                      else
                      {
                          // если вопроса нет, понижаем вероятность
                          Tresponses [i].probability/=1.5;
                      }
                  }
                  if (k==1) Tresponses [ii].probability+=0.2; // если персонаж с даным ответом тоько один, то его вероятность резко повышается
                  // сортируем все ответы в соответствии их вероятности
                  for (int i = Tresponses.Count - 1; i > 0; i--)
                  {
                      for (int j = 0; j < i; j++)
                      {
                          if (Tresponses[j].probability > Tresponses[j + 1].probability)
                              Tresponses.Reverse(j, 2);
                      }
                  }
                  donequest.Add(id);
              }
              else if (q <= 0)
              { // ЕСЛИ ОТВЕТ ЛОЖЬ
                  // У всех вариантов ответа, у которых есть даннный вопрос, понижаем вероятность
                  for (int i=0; i<Tresponses.Count; i++)
                  {
                      if (findInVector (Tresponses [i].idQuest, id))
                      {
                          Tresponses [i].probability/=4;
                          // if (Tresponses [i].probability<0) {Tresponses [i].probability*=0.001; Tresponses [i].probability=abs (Tresponses [i].probability); }
                          for (int j=0; j<Tresponses [i].idQuest.Count; j++)
                          {
                              if (Tresponses [i].idQuest [j] ==id) Tresponses [i].idQuest [j] =-1;
                          }
                      }
                      else
                      {
                          // а у кого нет, повышаем
                          Tresponses [i].probability+=0.05;
                      }
                  }
                  // сортируем все ответы в соответствии их вероятности
                  for (int i = Tresponses.Count - 1; i > 0; i--)
                  {
                      for (int j = 0; j < i; j++)
                      {
                          if (Tresponses[j].probability > Tresponses [j + 1].probability)
                              Tresponses.Reverse(j, 2);
                      }
                  }
              }
              else if (q==3)
              { // Ответ Скорее да
                  int k = 0; int ii=0;
                  for (int i=0; i<Tresponses.Count; i++)
                  {
                      if (findInVector (Tresponses [i].idQuest, id))
                      {
                          k++;
                          ii=i;
                          Tresponses [i].probability*=3;
                          for (int j=0; j<Tresponses [i].idQuest.Count; j++)
                          {
                              if (Tresponses [i].idQuest [j] ==id) Tresponses [i].idQuest [j] =-1;
                          }
                      }
                      else
                      {
                          // если вопроса нет, понижаем вероятность
                          Tresponses [i].probability-=0.01;
                      }
                  }
                  if (k==1) Tresponses [ii].probability+=0.15; // если персонаж с даным ответом тоько один, то его вероятность резко повышается
                  // сортируем все ответы в соответствии их вероятности
                  for (int i = Tresponses.Count - 1; i > 0; i--)
                  {
                      for (int j = 0; j < i; j++)
                      {
                          if (Tresponses [j].probability > Tresponses [j + 1].probability)
                              Tresponses.Reverse(j, 2);
                      }
                  }
                  donequest.Add(id);
              }
              else if (q==4)
              {
                  for (int i=0; i<Tresponses.Count; i++)
                  {
                      if (findInVector (Tresponses [i].idQuest, id))
                      {
                          Tresponses [i].probability-=0.15;
                          if (Tresponses [i].probability<0) { Tresponses [i].probability*=0.001; Tresponses [i].probability=Math.Abs(Tresponses [i].probability); }
                          for (int j=0; j<Tresponses [i].idQuest.Count; j++)
                          {
                              if (Tresponses [i].idQuest [j] ==id) Tresponses [i].idQuest [j] =-1;
                          }
                      }
                      else
                      {
                          // а у кого нет, повышаем
                          Tresponses[i].probability+=0.045;
                      }
                  }
                  // сортируем все ответы в соответствии их вероятности
                  for (int i = Tresponses.Count - 1; i > 0; i--)
                  {
                      for (int j = 0; j < i; j++)
                      {
                          if (Tresponses[j].probability > Tresponses[j + 1].probability)
                              Tresponses.Reverse(j, 2);
                      }
                  }
              }
          }

          bool findInVector (List <int> v, int id)
          {
              for (int i=0; i<v.Count; i++)
              {
                  if (v [i] ==id) return true;
              }
              return false;
          }
        
          bool  findInVector (List <SQuestion> v, int id)
          {
              for (int i=0; i<v.Count; i++)
              {
                  if (v[i].id==id) return true;
              }
              return false;
          }

          public int getResponse (int id)
          {
              // попытка получить ответ
              // Ответ есть, если разница между вероятностью двух, на данный
              // момент самых подходящих, ответов больше какой-то константы
              if (Tresponses [Tresponses.Count - 1].probability-Tresponses [Tresponses.Count - 2].probability >= 0.05 || id<0)
              { // ответ есть
                  return Tresponses.Count - 1;
              }
              else return 0;
          }

          public SResponse getfResponse (int id)
          {
              return Tresponses[id];
          }
        
          public void setResponse (int id, bool flag)
          {
              // if (flag)
              // responses [id].probability+=0.001;
          }

          public void newResponse()
          {
              Console.SetCursorPosition(3, 4);
              Console.WriteLine("Введите наименование поломки:");
              Console.SetCursorPosition(3, 5);
              string name = Console.ReadLine();

              Console.SetCursorPosition(3, 6);
              Console.WriteLine("Введите описание поломки:");
              Console.SetCursorPosition(3, 7);
              string response = Console.ReadLine();

              Console.SetCursorPosition(3, 8);
              Console.WriteLine("Введите путь к файлу:");
              Console.SetCursorPosition(3, 9);
              string filename = Console.ReadLine();

              // Добавление новго ответа в базу;
              SResponse thisResponse = new SResponse();
              thisResponse.response = name;
              thisResponse.description = response;
              thisResponse.idQuest = new List<int>();
              thisResponse.probability = 0.001;
              thisResponse.image = filename;
              
              responses.Add(thisResponse);

              SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Answers (name,description,image) VALUES ('" +
                name + "', '" + response + "', '" + filename + "')");
              cmd.Connection = sqlConnectionKB;
              cmd.ExecuteNonQuery();

              int newId = 0;
              cmd = new SqlCeCommand("SELECT id FROM Answers WHERE id = @@Identity;", sqlConnectionKB);
              SqlCeDataReader myReader = cmd.ExecuteReader();
              if (myReader.Read())
              {
                  newId = Int32.Parse(myReader["id"].ToString());
              }

              cmd = new SqlCeCommand("INSERT INTO Answer (kod,startVer) VALUES (" +
                newId + ", " + thisResponse.probability.ToString(CultureInfo.GetCultureInfo("en-GB")) + ")");
              cmd.Connection = sqlConnectionDB;
              cmd.ExecuteNonQuery();
          }

          public void editResponse(int id)
          {
              SResponse thisResponse = Tresponses[id-1];

              Console.SetCursorPosition(3, 4);
              Console.WriteLine("Выберете раздел для редактирования:");
              Console.SetCursorPosition(3, 6);
              Console.WriteLine("1. Наименование:" + thisResponse.response);
              Console.SetCursorPosition(3, 7);
              Console.WriteLine("2. Описание:" + thisResponse.description);
              Console.SetCursorPosition(3, 8);
              Console.WriteLine("3. Путь к файлу:" + thisResponse.image);
              Console.SetCursorPosition(3, 9);
              Console.WriteLine("4. Добавить вопрос");
              Console.SetCursorPosition(3, 10);
              Console.WriteLine("0. Выход");
              Console.SetCursorPosition(3, 11);
              
              int a = -1;
              do
              {
                  if (!int.TryParse(Console.ReadLine(), out a))
                      a = -1;
              } while (a == -1);

              if (a == 0)
                  return;
              else if (a != 4)
              {
                  Console.SetCursorPosition(3, 12);
                  Console.WriteLine("Введите новый текст:");
                  Console.SetCursorPosition(3, 13);

                  string line = Console.ReadLine();

                  if (a == 1)
                      thisResponse.response = line;
                  if (a == 2)
                      thisResponse.description = line;
                  if (a == 3)
                      thisResponse.image = line;

                  SqlCeCommand cmd = new SqlCeCommand("UPDATE Answers SET name='" + thisResponse.response + "', description='" + thisResponse.description + "', image='" + thisResponse.image + "' WHERE id=" +
                     thisResponse.id );
                  cmd.Connection = sqlConnectionKB;
                  cmd.ExecuteNonQuery();
              }
              else
              {
                  Console.SetCursorPosition(3, 13);
                  Console.WriteLine("Выберете вопрос:");
                  Console.SetCursorPosition(3, 14);
                  Console.WriteLine("0. Создать новый");
                  for (int i = 0; i < questions.Count; i++)
                  {
                      Console.SetCursorPosition(3, 15 + i);

                      bool fnd = false;
                      foreach (int el in thisResponse.idQuest)
                      {
                          if (el==questions[i].id)
                          {
                              fnd = true;
                              break;
                          }
                      }
                      if (!fnd)
                          Console.WriteLine(questions[i].id + ". " + questions[i].question);
                      else
                          Console.WriteLine("Добавлен. " + questions[i].question);
                  }
                  Console.SetCursorPosition(3, 15);
                  a = -1;
                  do
                  {
                      if (!int.TryParse(Console.ReadLine(), out a))
                          a = -1;
                  } while (a == -1);

                  if (a == 0)
                  {
                      Program.draw();
                      Console.SetCursorPosition(3, 3);
                      Console.WriteLine("Введите вопрос");
                      string line = Console.ReadLine();
                     
                      SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Question (question) VALUES ('" + line + "')");                     
                      cmd.Connection = sqlConnectionDB;
                      cmd.ExecuteNonQuery();

                      int newId = 0;
                      cmd = new SqlCeCommand("SELECT id FROM Question WHERE id = @@Identity;", sqlConnectionDB);
                      SqlCeDataReader myReader = cmd.ExecuteReader();
                      if (myReader.Read())
                      {
                          newId = Int32.Parse(myReader["id"].ToString());
                      }
                      
                      Tquestions.Add(new SQuestion(newId, line));

                      cmd = new SqlCeCommand("INSERT INTO QuestAnswers (answer, question) VALUES ("+id+","+newId+")");
                      cmd.Connection = sqlConnectionDB;
                      cmd.ExecuteNonQuery();

                      thisResponse.idQuest.Add(newId);
                  }
                  else
                  {
                      SqlCeCommand cmd = new SqlCeCommand("INSERT INTO QuestAnswers (answer, question) VALUES (" + id + "," + a + ")");
                      cmd.Connection = sqlConnectionDB;
                      cmd.ExecuteNonQuery();

                      thisResponse.idQuest.Add(a);

                  }
              }


              // Добавление новго ответа в базу;
              /*
              thisResponse.response = name;
              thisResponse.description = response;
              thisResponse.idQuest = new List<int>();
              thisResponse.probability = 0.001;
              thisResponse.image = filename;

              responses.Add(thisResponse);

              SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Answers (name,description,image) VALUES ('" +
                name + "', '" + response + "', '" + filename + "')");
              cmd.Connection = sqlConnectionKB;
              cmd.ExecuteNonQuery();

              int newId = 0;
              cmd = new SqlCeCommand("SELECT id FROM Answers WHERE id = @@Identity;", sqlConnectionKB);
              SqlCeDataReader myReader = cmd.ExecuteReader();
              if (myReader.Read())
              {
                  newId = Int32.Parse(myReader["id"].ToString());
              }

              cmd = new SqlCeCommand("INSERT INTO Answer (kod,startVer) VALUES (" +
                newId + ", " + thisResponse.probability.ToString(CultureInfo.GetCultureInfo("en-GB")) + ")");
              cmd.Connection = sqlConnectionDB;
              cmd.ExecuteNonQuery();*/
          }

        

          public void newQuestion (string q)
          {
              // новый вопрос
              Console.WriteLine("Введите вопрос, который позволит отличить " + q + " от " + Tresponses [Tresponses.Count - 1].response);
              
              string newQ = Console.ReadLine();
              SQuestion thisQuestion = new SQuestion();
              thisQuestion.id = maxid (questions) +1;
              thisQuestion.question = newQ;
              for (int i=0; i<responses.Count; i++)
              {
                  if (responses[i].response == q)
                  {
                      responses[i].idQuest.Add(thisQuestion.id);
                  }
              }
              questions.Add(thisQuestion);
          }
        
          public int maxid (List <SQuestion> _questions)
          {
              int max=0;
              for (int i=0; i<_questions.Count; i++)
              {
                  if (_questions [i].id>max) max=_questions [i].id;
              }
              return max;
          }

          public void dellQuestion (int id)
          {
              // удаление вопроса
              for (int i=0; i<Tresponses.Count; i++)
              {
                  if (findInVector (Tresponses [i].idQuest, id))
                  {
                      for (int j=0; j<Tresponses [i].idQuest.Count; j++)
                      {
                          if (Tresponses [i].idQuest [j] ==id) Tresponses [i].idQuest [j] =-1;
                      }
                  }
              }
          }
        


        public bool havequestions()
        {
            for (int i = 0; i < Tresponses.Count; i++)
            {
                for (int j = 0; j < Tresponses[i].idQuest.Count; j++)
                {
                    if (Tresponses[i].idQuest[j] != -1) return true;
                }
            }
            return false;
        }

        public int populatQuestion()
        {
            int maxCount = 0;
            int mid = 0;
            for (int _id = 1; _id <= questions[questions.Count - 1].id; _id++) // для каждого вопроса
            {
                int thisCount = 0;
                for (int i = 0; i < Tresponses.Count; i++)
                {
                    for (int j = 0; j < Tresponses[i].idQuest.Count; j++)
                    {
                        if (Tresponses[i].idQuest[j] == _id) thisCount++;
                        if (thisCount > maxCount)
                        {
                            maxCount = thisCount;
                            mid = _id;
                        }
                    }
                }
            }
            return mid;
        }

        public void questionList()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.SetCursorPosition(3, 4 + i);
                Console.WriteLine(questions[i].id + ". " + questions[i].question);
            }
        }

        public void answersList()
        {
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("0. Добавить новый");

            for (int i = 0; i < responses.Count; i++)
            {
                Console.SetCursorPosition(3, 5 + i);
                Console.WriteLine((i+1) + ". " + responses[i].response);
            }
        }
    }
}
