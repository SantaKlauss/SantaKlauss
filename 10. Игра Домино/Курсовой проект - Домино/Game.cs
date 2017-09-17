using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
namespace Курсовой_проект___Домино
{
    public class Game
    {

        /*static int[] AllK={{"0","|","0"},{"0","|","1"},{"0","|","2"},{"0","|","3"},{"0","|","4"},{"0","|","5"},{"0","|","6"},
                            {"1","|","1"},{"1","|","2"},{"1","|","3"},{"1","|","4"},{"1","|","5"},{"1","|","6"},
                            {"2","|","2"},{"2","|","3"},{"2","|","4"},{"2","|","5"},{"2","|","6"},
                            {"3","|","3"},{"3","|","4"},{"3","|","5"},{"3","|","6"},
                            {"4","|","4"},{"4","|","5"},{"4","|","6"},
                            {"5","|","5"},{"5","|","6"},
                             {"6","|","6"} };*/
        static string[] AllK = { "0|0","0|1","0|2","0|3","0|4","0|5","0|6","1|1","1|2","1|3","1|4","1|5","1|6","2|2", 
                                 "2|3","2|4","2|5","2|6","3|3","3|4","3|5","3|6","4|4","4|5","4|6","5|5","5|6","6|6"}; //значения на костях домино

        List<string> K = new List<string>(AllK); //список домино на базаре(все кости)
        List<Kosti> PlayerK = new List<Kosti>(); // список домино игрока
        List<Kosti> CompK = new List<Kosti>();  //список домино компа
        List<Kosti> TableK = new List<Kosti>(); //список домино на игровом столе
        Random rnd = new Random();  // генератор чисел


        public Game()
        { // Конструктор игры
            for (int i = 0; i < 7; i++)//просматриваем в цикле только 7 элементов, которые будут добавлять игрок и комп
            {
                int bit = rnd.Next(0, K.Count);//определяем bit - объект игры(выбирается случайно из диапазона)
                int p2 = 150 + i*30;// координаты и интервал между доминошками игрока
                int p3 = Form.ActiveForm.Height - 66;//
                int p4 = 90;

                Kosti p = new Kosti(K.ElementAt(bit), p2, p3, p4, true,true);//ElementAt - возвращаем элемент с базара
                PlayerK.Add(p);//и добавляем на руки


                K.RemoveAt(bit);// удаляем с базара после добавления 

              bit = rnd.Next(0, K.Count);// bit - объект игры(выбирается случайно из диапазона)

                int c2 = 150 + i * 30;//координаты и интервал между доминошками компа
                int c3 = Form.ActiveForm.Height - 130;//делаем форму активной чтобы доминошки появились + координаты
               int c4 = 90;//угол поворота

               Kosti c = new Kosti(K.ElementAt(bit), c2, c3, c4, true, false);//1-видимость домино 2- видимость значений
                CompK.Add(c);

                K.RemoveAt(bit); // удаляем с базара после добавленияlse
            }
        } 


        public int GoBazar()
        { //ф-я взятия домино с базара

            int bazar = K.Count;// 
            if (bazar == 0)
            {// если нет домино на базаре
                if (TableK.Count == 0)//если на игровом столе нет домино
                {
                    MessageBox.Show("Базар пуст!!!!!!");//текстовое сообщение
                    return 0; }


                for (int i = 0; i < PlayerK.Count; i++)
                {// в цикле просматриваем элементы игрока
                  

                    if (i == PlayerK.Count - 1)//Если у игрока нет подходящих домино
                    {

                        //MessageBox.Show("ПОРАЖЕНИЕ!!!");
                        MessageBox.Show(Kol());//показываем функцию с результатами
                        // Application.Restart();

                        //Form2 f = new Form2();//
                        // f.ShowDialog();//Вызываем форму 2
                        return 0;


                    }





                }
                MessageBox.Show("БАЗАР ПУСТ!!!!!!");//тестовое сообщение"базар пуст"
                return 0;
            }

                                             

            int bit = rnd.Next(0, bazar);// определяем объект домино bit
            if (PlayerK.  Count == 0)//если у игрока нет  костей домино
            {
                int p2 = 150;//отступ
                int p3 = Form.ActiveForm.Height - 66;//форма активна  + высота  элемента
                int p4 = 90;//угол расположения

                Kosti m = new Kosti(K.ElementAt(bit), p2, p3, p4, true,true);
                PlayerK.Add(m);

            }
            else//если у игрока есть кости домино
            {

                int p2 = PlayerK.Last().pict.Location.X + 43;//добавляем а конец списка по координатами оси х
                int p3 = Form.ActiveForm.Height - 66;
                int p4 = 90;
                Kosti m = new Kosti(K.ElementAt(bit), p2, p3, p4, true, true);
                PlayerK.Add(m);//игрок добавляет доминошки
                                

            }

            K.RemoveAt(bit);//удаляем  кости с базара после взятия на руки
            return bazar - 1;
        }

        public string Kol()// cчитаем сумму на домино 
        {
            int Playerkol = 0;
            int Compkol = 0;

            DialogResult result;
            {// диалог
                result = DialogResult.No;

                SaveFileDialog SF = new SaveFileDialog();// запрос для сохранения файла
                StreamWriter sw = new StreamWriter(Application.StartupPath + "/result.txt");

                for (int i = 0; i <= PlayerK.Count - 1; i++)
                { 

                    Playerkol += Convert.ToInt32(PlayerK.ElementAt(i).Zn[0].ToString()) +
                                 Convert.ToInt32(PlayerK.ElementAt(i).Zn[2].ToString());
                }// конвертируем чтобы значения можно было суммировать для рез-та

                for (int i = 0; i <= CompK.Count - 1; i++)//просматриваем домино компа и также конвертируем для рез-та
                {
                    Compkol += Convert.ToInt32(CompK.ElementAt(i).Zn[0].ToString()) +
                               Convert.ToInt32(CompK.ElementAt(i).Zn[2].ToString());
                }


                if (Playerkol > Compkol)//если у игрока больше сумма очков на домино чем у компа
                {
                    result = MessageBox.Show("Ваши очки: " + Playerkol + ", очки компьютера: " + Compkol + "\n\r Вы проиграли! Cохранить результаты игры?", "Результаты и их сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    sw.WriteLine(result);
                   // sw.Close();
                }




                if (Playerkol < Compkol)//если сумма очков у компа больше чем у игрока
                {
                    result = MessageBox.Show("Ваши очки:" + Playerkol + ",очки компьютера:" + Compkol + "\n\r Вы выиграли! Cохранить результаты игры?", "Предложение продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    sw.WriteLine(result);
                //    sw.Close();
                }
                if (Playerkol == Compkol)
                {
                    result = MessageBox.Show("Ваши очки: " + Playerkol + ", очки компьютера: " + Compkol + "\n\r Ничья!Cохранить результаты игры?", "Предложение продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    sw.WriteLine(result);
                //    sw.Close();
                }

               // result = DialogResult.Yes;
                

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // SaveFileDialog SFs = new SaveFileDialog();
                    SF.FileName = "result.txt";
                    SF.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    SF.DefaultExt = "*.txt";
                    if (SF.ShowDialog() == DialogResult.OK)
                    {
                       // StreamWriter sw = new StreamWriter(SF.FileName, true);
                        sw.WriteLine("Ваши очки: " + Playerkol + ", очки компьютера: " + Compkol + "\n\r");
                        sw.Close();
                        result = MessageBox.Show("Файл Успешно Сохранён!!! Продолжить игру ?", "Предложение продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Yes) { Application.Restart(); }
                        if (result == System.Windows.Forms.DialogResult.No) { Application.Exit(); }
                    }
                    else
                    {
                        if (SF.ShowDialog() != DialogResult.OK)
                        {
                            result = MessageBox.Show("Файл Не Сохранён!!! Продолжить игру ?", "Предложение продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == System.Windows.Forms.DialogResult.Yes) { Application.Restart(); }
                            if (result == System.Windows.Forms.DialogResult.No) { Application.Exit(); }

                        }
                    }
                }
                else
                {


                    if (result == System.Windows.Forms.DialogResult.No)
                    {

                        result = MessageBox.Show("Файл Не Сохранён!!! Продолжить игру ?", "Предложение продолжить", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Yes) { Application.Restart(); }
                        if (result == System.Windows.Forms.DialogResult.No) { Application.Exit(); }
                    }
                }


                sw.Close();

                return " ";
            }
        }


        public void PlayerMove(Kosti p1)//ход игрока
        {
            int bit = PlayerK.IndexOf(p1); 
            if (bit == -1)
                return;
            if (TableK.Count != 0 &&
                TableK.First().Zn[0] != p1.Zn[0] &&
                TableK.First().Zn[0] != p1.Zn[2] &&
                TableK.Last().Zn[2] != p1.Zn[0] &&
                TableK.Last().Zn[2] != p1.Zn[2])
            { // //Если домино нельзя положить на стол - выход
                return;
            }

            PeremStkvka(p1); //Переместить домино

            if (TableK.Count == 0)
            {
                TableK.Add(PlayerK.ElementAt(bit));
            } //Добавление первой домино на стол
            else
            {
                if (TableK.First().Zn[0] == p1.Zn[2])
                {
                    TableK.Insert(0, PlayerK.ElementAt(bit));
                } //Добавление домино в началок списка домино стола
                else
                {
                    TableK.Add(PlayerK.ElementAt(bit));
                }
            } // //Добавление домино в конец списка домино стола
            PlayerK.RemoveAt(bit); //Удаление домино от игрока
            SortPlayerK(); //Сортировка домино игрока
            CompMove(); //Ход компьютера
            SortCompK();
        } ////Сортировка домино компьютера


        public void CompMove()
        { // Ход компьютера
         
            Kosti p1;
               
                        int bit = rnd.Next(0, K.Count);
            
            if (K.Count == 0)
            {
                if (CompK.Count == 0)
                {//Если на базаре пусто - игрок выиграл
                    //MessageBox.Show("Проиграаааааааааали!!!!!");
                    MessageBox.Show(Kol());
                    //Application.Restart();
                  //  Form2 frmContinue = new Form2();
                   // frmContinue.ShowDialog();
                    return;
                }
            }

            if (CompK.Count == 0)
            {// Если у компа нечем  ходить

                CompK.Add(new Kosti(K.ElementAt(bit), 150, Form.ActiveForm.Height - 130, 90, true, true));
                K.RemoveAt(bit);
                Form.ActiveForm.Controls["button1"].Text = "БАЗАР (" + K.Count + ")";
            } //кликаем базар 
            for (int i = 0; i < CompK.Count; i++)
            { //Перебор доминошек компа, выбор нужной и перемещение на стол
                p1 = CompK.ElementAt(i);
               // p1.pict.Visible = false;////////////////////////////////
               //black = CompK.ElementAt(i); ////////////////////
               //black.pict.Visible = false;
                if (TableK.Count == 0)
                {//если на столе ничего
                    
                    PeremStkvka(p1);
                    p1.pict.BringToFront();
                    TableK.Add(CompK.ElementAt(i));
                    CompK.RemoveAt(i);
                    return;
                }

                if (TableK.First().Zn[0] == p1.Zn[0] ||
                    TableK.First().Zn[0] == p1.Zn[2] ||
                    TableK.Last().Zn[2] == p1.Zn[0] ||
                    TableK.Last().Zn[2] == p1.Zn[2])
                {
                   // bool p5;
                    CompK.ElementAt(i).pict.Visible = true;
                    //CompK.ElementAt(i).pict.Visible = p5;
                    PeremStkvka(p1);
                    p1.pict.BringToFront();
                    if (TableK.First().Zn[0] == p1.Zn[2])
                    {
                        TableK.Insert(0, CompK.ElementAt(i));
                    }
                    else { TableK.Add(CompK.ElementAt(i)); }
                    CompK.RemoveAt(i);
                    return;
                }

                int bazar = K.Count;
                bit = rnd.Next(0, K.Count);
                if (i == CompK.Count - 1)
                {//Если у компа нет подходящих домино
                    if (bazar == 0)
                    { //Если на базаре пусто - игрок выиграл
                        //MessageBox.Show("Уррааа!!!ПОБЕДА!!!");
                        MessageBox.Show(Kol());
                        //Application.Restart();
                        //Form2 frmContinue = new Form2();
                        //frmContinue.ShowDialog();
                        return;
                    }
                    CompK.Add(new Kosti(K.ElementAt(bit), CompK.Last().pict.Location.X + 43, Form.ActiveForm.Height - 130, 90, true, false));// комп добавляет доминошки в конец списка
                    K.RemoveAt(bit);
                    Form.ActiveForm.Controls["button1"].Text = "БАЗАР (" + K.Count + ")";
                }
            }
        }


        public void SortCompK()
        { //Сортируем домино компа
            for (int i = 0; i < CompK.Count; i++)
            {
                // try
                // {
                int x = 150 + i * 30 - 13;
                int y = Form.ActiveForm.Height-130-24;
                CompK.ElementAt(i).pict.Location = new System.Drawing.Point(x, y);
                // }
                // catch { }
            }
        }

        public void SortPlayerK()
        { //Сортируем своё домино
            for (int i = 0; i < PlayerK.Count; i++)
            {
                int x = 150 + i * 30 - 13;
                int y = Form.ActiveForm.Height - 66 - 24;
                PlayerK.ElementAt(i).pict.Location = new System.Drawing.Point(x, y);
            }
        }



        public void PeremStkvka(Kosti p1)  //Перемещение домино (эта также функция выполняет попиксельный подбор положений костей домино на игровом столе, выполяет стыковку костей домино)
        {
            if (p1.Zn[0] != p1.Zn[2])
            {
                p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                p1.pict.Refresh();//перерисовка
                //System.Media.SoundPlayer a = new System.Media.SoundPlayer("C:\\Users\\валентина\\Desktop\\Курсовой проект - Домино\\Курсовой проект - Домино\\Sound\\Базар-Sound.wav");
                //a.Play();//звук
            }
            if (TableK.Count == 0)
            {//если на столе ничего
                
                p1.pict.Location = new System.Drawing.Point(Form.ActiveForm.Width/2 - p1.pict.Width/2,Form.ActiveForm.Height/ 8-p1.pict.Height / 2);
            }// задаём расположение первой домино на столе
            else
            {
                int a = p1.pict.Image.Width,
                    b = p1.pict.Image.Height,
                XF = TableK.First().pict.Location.X,
                YF = TableK.First().pict.Location.Y,
                AF = TableK.First().pict.Image.Width,
                BF = TableK.First().pict.Image.Height,

                XL = TableK.Last().pict.Location.X,
                YL = TableK.Last().pict.Location.Y,
                AL = TableK.Last().pict.Image.Width,
                BL = TableK.Last().pict.Image.Height;

                TableK.First().pict.Width = AF;// ширина первой домино на столе
                TableK.First().pict.Height = BF;//высота
                TableK.Last().pict.Width = AL;// последней
                TableK.Last().pict.Height = BL;

                if (p1.Zn[0] == p1.Zn[2])
                {
                    if (TableK.First().Zn[0] == p1.Zn[0])//если значение домино на столе = значению выставляемого домино
                    {
                        if (XF < 100)
                        {
                            p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);//поворачиваем
                            p1.pict.Refresh();//перерисовка
                            p1.pict.Location = new System.Drawing.Point(XF - a / 4, YF + BF);
                            return;
                        }
                        p1.pict.Location = new System.Drawing.Point(XF - a, YF - b / 4);
                    }
                    else
                    {
                        if (XL > 1000)
                        {
                            p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                            p1.pict.Refresh();
                            p1.pict.Location = new System.Drawing.Point(XL - a / 4, YL + BL);
                            return;
                        }
                        p1.pict.Location = new System.Drawing.Point(XL + AL, YL - b / 4);
                    }
                }
                else




                {
                    if (TableK.First().Zn[0] == p1.Zn[2])
                    {
                        if (XF < 100)
                        {
                            p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                            p1.pict.Refresh();
                            p1.pict.Location = new System.Drawing.Point((TableK.First().Zn[0] == TableK.First().Zn[2]) ? XF + AF / 4 : XF, YF + BF);
                            return;
                        }
                        p1.pict.Location = new System.Drawing.Point(XF - a, (TableK.First().Zn[0] == TableK.First().Zn[2]) ? YF + BF / 4 : YF);
                    }



                    else
                        if (TableK.First().Zn[0] == p1.Zn[0])
                        {
                            if (XF < 100)
                            {



                                p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                                p1.pict.Refresh();

                                p1.Zn = p1.Zn[2] + "|" + p1.Zn[0];
                                p1.pict.Location = new System.Drawing.Point((TableK.First().Zn[0] == TableK.First().Zn[2]) ? XF + AF / 4 : XF, YF + BF);
                                return;


                            }
                            p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                            p1.pict.Refresh();
                            p1.Zn = p1.Zn[2] + "|" + p1.Zn[0];
                            p1.pict.Location = new System.Drawing.Point(XF - a, (TableK.First().Zn[0] == TableK.First().Zn[2]) ? YF + BF / 4 : YF);
                        }
                        else
                            if (TableK.Last().Zn[2] == p1.Zn[0])
                            {
                                if (XL > 1000)
                                {
                                    p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                                    p1.pict.Refresh();

                                    p1.pict.Location = new System.Drawing.Point((TableK.Last().Zn[0] == TableK.Last().Zn[2]) ? XL + AL / 4 : XL + ((AL > 30) ? AL / 2 : 0), YL + BL);
                                    return;
                                }



                                p1.pict.Location = new System.Drawing.Point(XL + AL, (TableK.Last().Zn[0] == TableK.Last().Zn[2]) ? YL + BL / 4 : YL);
                            }
                            else
                                if (TableK.Last().Zn[2] == p1.Zn[2])
                                {
                                    if (XL > 1000)
                                    {
                                        p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
                                        p1.pict.Refresh();
                                        p1.Zn = p1.Zn[2] + "|" + p1.Zn[0];
                                        p1.pict.Location = new System.Drawing.Point((TableK.Last().Zn[0] == TableK.Last().Zn[2]) ? XL + AL / 4 : XL + ((AL > 30) ? AL / 2 : 0), YL + BL);
                                        return;
                                    }
                                    p1.pict.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                                    p1.pict.Refresh();
                                    p1.Zn = p1.Zn[2] + "|" + p1.Zn[0];
                                    p1.pict.Location = new System.Drawing.Point(XL + AL, (TableK.Last().Zn[0] == TableK.Last().Zn[2]) ? YL + BL / 4 : YL);
                                }
                }
            }
        }






    };
}
