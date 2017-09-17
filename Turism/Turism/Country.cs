using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    //страна
    class Country
    {
        public int id;         //номер в базе данных
        public string name; //наименование страны
        public string description; //описание страны
        

        public int[] seasons;           //индексы сезонов, 12 элементов, которые содержат значения 1-5
        public List<Transport> transport;   //список транспорта, на котором можно добраться
        public List<Hotel> hotels;      //список отелей
        
        //конструктор
        public Country(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;

            seasons = new int[12];  //создаем массив для дальнейшего использования            
        }

        //получить добавочную стоимость
        public float getAdditionalCost()
        {
            return MySql.getAdditionalCost(id);
        }

        //добавить сезон к массиву
        public void addSeason(int month, int season)
        {
            seasons[month] = season;
        }            

        //загрузить транспорт из бд
        public void loadTransport()
        {
            transport = MySql.getTransport(id);
        }

        //получить список компаний, предоставляющих транспортные услуги
        public List<string> getTransportCompanies()
        {
            List<string> result = new List<string>();

            //перебираем весь массив
            for (int i = 0; i < transport.Count; i++)
            {
                bool isEl = false;
                //ищем уникального поставщика
                for (int j = 0; j < result.Count; j++)
                {
                    if (transport[i].company == result[j])
                    {
                        isEl = true;
                        break;
                    }
                }

                //если нашли, добавляем
                if (!isEl)
                {
                    result.Add(transport[i].company);
                }
            }

            return result;
        }

        //получить список отелей
        public void loadHotels()
        {
            hotels = MySql.getHotels(id);
        }

        //получить коэф в зависимости от сезона
        public float getSeasonK(int id)
        {
            return MySql.getSeasonK(seasons[id]);
        }

        //получить наименование сезона для отчета
        public string getSeasonName(int id)
        {
            return MySql.getSeasonName(seasons[id]);
        }
    }
}
