using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Turism
{
    class MySql
    {
        static string name = "turism";  //имя базы данных
        static string pass = "";        //пароль
        static string login = "root";       //логин пользователя
        static string host = "localhost";   //адрес бд

        static MySqlConnection myConnection;

        public static bool init()
        {
            try
            {
                //строка подключения
                string Connect = "Database=" + name +
                            ";Data Source=" +
                            host + ";User Id=" +
                            login + ";Password=" + pass;

                myConnection = new MySqlConnection(Connect);
                myConnection.Open(); //Устанавливаем соединение с базой данных. 
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
                      
        }

        public static void close()
        {
            if (myConnection!=null)
                myConnection.Close(); //Обязательно закрываем соединение!
        }

        static public void deleteCountry(string name)
        {
            string CommandText = "SELECT id FROM countries WHERE name='"+name+"' LIMIT 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            int id = 0;
            //для всех полученных строк
            if (MyDataReader.Read())
            {
                id = MyDataReader.GetInt32(0);
            }
            MyDataReader.Close();

            CommandText = "DELETE FROM countries WHERE id = " + id;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();

            CommandText = "DELETE FROM seasons WHERE country = " + id;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void editCountry(string name, string description, int [] seasons)
        {
            string CommandText = "SELECT id FROM countries WHERE name='" + name + "' LIMIT 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            int id = 0;
            //для всех полученных строк
            if (MyDataReader.Read())
            {
                id = MyDataReader.GetInt32(0);
            }
            MyDataReader.Close();

            CommandText = "UPDATE countries SET name='" + name + "', description='" + description + "' WHERE id=" + id;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();


            

            for (int i = 1; i <= 12; i++)
            {
                CommandText = "UPDATE seasons SET season=" + seasons[i - 1] + " WHERE country=" + id + " AND month= " + i;

                myCommand = new MySqlCommand(CommandText, myConnection);

                myCommand.ExecuteNonQuery();
            }
        }

        static public void addCountry(string name, string description)
        {
            string CommandText = "INSERT INTO countries (id,name,description) VALUES (NULL,'"+name+"','"+description+"')";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            myCommand.ExecuteNonQuery();

            CommandText = "SELECT id FROM countries WHERE 1 ORDER BY id desc LIMIT 1";

            myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            int id = 0;
            //для всех полученных строк
            if (MyDataReader.Read())
            {
                id = MyDataReader.GetInt32(0);
            }

            MyDataReader.Close();

            for (int i = 1; i <= 12; i++)
            {
                CommandText = "INSERT INTO seasons (id,country,season,month) VALUES (NULL," + id + ", 1, "+i+")";

                myCommand = new MySqlCommand(CommandText, myConnection);

                myCommand.ExecuteNonQuery();
            }
        }

        //получить список стран
        static public List<Country> getCountries()
        {
            List<Country> result = new List<Country>();
            //запрос
            string CommandText = "SELECT * FROM countries WHERE 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();
            
            //для всех полученных строк
            while (MyDataReader.Read())
            {
                try
                {
                    //добавляем в результат
                    result.Add(new Country(MyDataReader.GetInt32(0),
                                            MyDataReader.GetString(1),
                                            MyDataReader.GetString(2)));
                }
                catch (System.Exception ex)
                {
                    MyDataReader.Close();
                    return null;
                }
                
               

            }
            MyDataReader.Close();

            return result;            
        }

        static public void getSeasons(List<Country> counties)
        {
            //запрос
            string CommandText = "SELECT * FROM seasons WHERE 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                int country = MyDataReader.GetInt32(1);
                int season = MyDataReader.GetInt32(2);
                int month = MyDataReader.GetInt32(3);

                for (int i = 0; i < counties.Count; i++)
                {
                    if (counties[i].id == country)
                        counties[i].addSeason(month - 1, season - 1);
                }
            }
            MyDataReader.Close();
        }

        static public void addTransport(string name)
        {
            string CommandText = "INSERT INTO transportcompany (id,transport) VALUES (NULL, '" + name + "')";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void deleteTransport(string name)
        {
            string CommandText = "DELETE FROM transportcompany WHERE name='" + name + "')";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public List<string> getTransportName()
        {
            List<string> result = new List<string>();
            //запрос
            string CommandText = "SELECT * FROM transportcompany WHERE 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                result.Add(MyDataReader.GetString(1));
            }
            MyDataReader.Close();

            return result;
        }

        static public List<Transport> getTransportTarifs()
        {
            List<Transport> result = new List<Transport>();
            //запрос
            string CommandText = "SELECT * FROM transporttarif,transportcompany WHERE transportcompany.id=transporttarif.company ORDER BY transporttarif.id";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                int tid = MyDataReader.GetInt32(0);
                string company = MyDataReader.GetString(1);
                string clType = MyDataReader.GetString(2);
                float cost = MyDataReader.GetFloat(4);

                Transport tr = new Transport(tid, company, clType, cost);
                tr.country = MyDataReader.GetInt32(3);
                tr.companyName = MyDataReader.GetString(6);

                result.Add(tr);
            }
            MyDataReader.Close();

            return result;
        }

        static public List<Transport> getTransport(int id)
        {
            List<Transport> result = new List<Transport>();
            //запрос
            string CommandText = "SELECT transporttarif.id, transportcompany.transport, transporttarif.name, transporttarif.cost "
                                  +"  FROM transporttarif,transportcompany WHERE transportcompany.id=transporttarif.company AND country=" + id;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                int tid = MyDataReader.GetInt32(0);
                string company = MyDataReader.GetString(1);
                string clType = MyDataReader.GetString(2);
                float cost = MyDataReader.GetFloat(3);

                result.Add(new Transport(tid, company, clType, cost));
            }
            MyDataReader.Close();

            return result;
        }

        static public List<Discount> getDiscountes()
        {
            List<Discount> result = new List<Discount>();
            //запрос
            string CommandText = "SELECT discount,name FROM discount WHERE 1" ;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                float cost = MyDataReader.GetFloat(0);
                string discount = MyDataReader.GetString(1);                

                result.Add(new Discount(discount, cost));
            }
            MyDataReader.Close();


            return result;
        }

        static public List<Hotel> getHotels(int id)
        {
            List<Hotel> result = new List<Hotel>();
            //запрос
            string CommandText = "SELECT name,category,cost,country "
                                  +"  FROM hotel WHERE country=" + id;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                string name = MyDataReader.GetString(0);
                int category = MyDataReader.GetInt32(1);
                float cost = MyDataReader.GetFloat(2);
                int country = MyDataReader.GetInt32(3);

                result.Add(new Hotel(name, category, cost, country));
            }
            MyDataReader.Close();

            return result;
        }

        static public List<Hotel> getHotels()
        {
            List<Hotel> result = new List<Hotel>();
            //запрос
            string CommandText = "SELECT name,category,cost,country "
                                  + "  FROM hotel WHERE 1" ;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                string name = MyDataReader.GetString(0);
                int category = MyDataReader.GetInt32(1);
                float cost = MyDataReader.GetFloat(2);
                int country = MyDataReader.GetInt32(3);

                result.Add(new Hotel(name, category, cost, country));
            }
            MyDataReader.Close();

            return result;
        }

        static public List<Strahovka> getStrahovka()
        {
            List<Strahovka> result = new List<Strahovka>();
            //запрос
            string CommandText = "SELECT name,cost "
                                  + "  FROM strahovka WHERE 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                string name = MyDataReader.GetString(0);
                float cost = MyDataReader.GetFloat(1);

                result.Add(new Strahovka(name, cost));
            }
            MyDataReader.Close();

            return result;
        }

        static public float getAdditionalCost(int id)
        {
            float result = 0;
            //запрос
            string CommandText = "SELECT cost "
                                  + "  FROM additioncost WHERE country=" + id;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                result = MyDataReader.GetFloat(0);
               
            }
            MyDataReader.Close();

            return result;
        }

        static public float getSeasonK(int ind)
        {
            float result = 0;
            //запрос
            string CommandText = "SELECT k "
                                  + "  FROM seasonskoefs WHERE id=" + ind;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                result = MyDataReader.GetFloat(0);

            }
            MyDataReader.Close();

            return result;
        }

        static public string getSeasonName(int ind)
        {
            string result = "";
            //запрос
            string CommandText = "SELECT name "
                                  + "  FROM seasonskoefs WHERE id=" + ind;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                result = MyDataReader.GetString(0);

            }
            MyDataReader.Close();

            return result;
        }

        static public void editCompany(string name)
        {
            string CommandText = "UPDATE transportcompany SET name='" + name + "' WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void editTransportTarif(int id, string name, float cost, string companyName, string countryName)
        {
            int company=0, country=0;

            string CommandText = "SELECT id FROM countries WHERE name='" + countryName + "'";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            if (MyDataReader.Read())
            {
                country = MyDataReader.GetInt32(0);
            }
            MyDataReader.Close();

            CommandText = "SELECT id FROM transportcompany WHERE transport='" + companyName + "'";
            myCommand = new MySqlCommand(CommandText, myConnection);
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            if (MyDataReader.Read())
                company = MyDataReader.GetInt32(0);
            MyDataReader.Close();


            CommandText = "UPDATE transporttarif SET name='" + name +
                        "', company=" + company + ", country="+country+", cost="+cost+" WHERE id=" + id;
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void deleteTransportTarif(int id)
        {
            string CommandText = "DELETE FROM transporttarif WHERE id=" + id;

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void addTransportTarif(string company, string country, string name, float cost)
        {
            string CommandText = "SELECT id FROM countries WHERE name='"+ country +"'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            MySqlDataReader MyDataReader = myCommand.ExecuteReader();
            int countryId = 0;
            if (MyDataReader.Read())
                countryId = MyDataReader.GetInt32(0);
            MyDataReader.Close();


            CommandText = "SELECT id FROM transportcompany WHERE transport='"+ company +"'";
            myCommand = new MySqlCommand(CommandText, myConnection);
            MyDataReader = myCommand.ExecuteReader();
            int companyId = 0;
            if (MyDataReader.Read())
                companyId = MyDataReader.GetInt32(0);
            MyDataReader.Close();

            CommandText = "INSERT INTO transporttarif (id,company,name,country,cost) VALUES (NULL, " + companyId + ", '" + name + "', " + countryId + "," + cost + ")";
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void addDisc(string name, float cost)
        {
            string CommandText = "INSERT INTO discount (id,discount,name) VALUES (NULL, " + cost + ", '" + name + "')";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void deleteDisc(string name)
        {
            string CommandText = "DELETE FROM discount WHERE name='"+name+"'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void editDisc(string name, string disc)
        {
            string CommandText = "UPDATE discount SET name='" + name + "', discount="+disc+" WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void addHotel(string name, string country, string zv, float cost)
        {
            string CommandText = "SELECT id FROM countries WHERE name='" + country + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            MySqlDataReader MyDataReader = myCommand.ExecuteReader();
            int countryId = 0;
            if (MyDataReader.Read())
                countryId = MyDataReader.GetInt32(0);
            MyDataReader.Close();


            CommandText = "INSERT INTO hotel (id,name,category,cost,country) VALUES (NULL, '" + name + "', " + zv + ", " + cost + "," + countryId + ")";
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void deleteHotel(string name)
        {
            string CommandText = "DELETE FROM hotel WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void editHotel(string name, string country, string zv, float cost)
        {
            string CommandText = "SELECT id FROM countries WHERE name='" + country + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            MySqlDataReader MyDataReader = myCommand.ExecuteReader();
            int countryId = 0;
            if (MyDataReader.Read())
                countryId = MyDataReader.GetInt32(0);
            MyDataReader.Close();


            CommandText = "UPDATE hotel SET name='" + name + "',category=" + zv + ",cost=" + cost + ",country=" + countryId + " WHERE name='" + name + "'";
            myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void addStrahovka(string name, float cost)
        {
            string CommandText = "INSERT INTO strahovka (id,cost,name) VALUES (NULL, " + cost + ", '" + name + "')";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void deleteStrahovka(string name)
        {
            string CommandText = "DELETE FROM strahovka WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }

        static public void editStrahovka(string name, string cost)
        {
            string CommandText = "UPDATE strahovka SET name='" + name + "', cost=" + cost + " WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }


        static public List<SeasonKoefs> getSeasonsKoefs()
        {
            List<SeasonKoefs> result = new List<SeasonKoefs>();
            //запрос
            string CommandText = "SELECT * FROM seasonskoefs WHERE 1";

            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            MySqlDataReader MyDataReader;
            MyDataReader = myCommand.ExecuteReader();

            //для всех полученных строк
            while (MyDataReader.Read())
            {
                string name = MyDataReader.GetString(1);
                float koef = MyDataReader.GetFloat(2);

                result.Add(new SeasonKoefs(name, koef));
            }
            MyDataReader.Close();

            return result;
        }

        static public void editSeasonsKoefs(string name, string koef)
        {
            string koefStr = koef;
            koefStr = koefStr.Replace(',', '.');

            string CommandText = "UPDATE seasonskoefs SET name='" + name + "', k=" + koefStr + " WHERE name='" + name + "'";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myCommand.ExecuteNonQuery();
        }
    }
}
