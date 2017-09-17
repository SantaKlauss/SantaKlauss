using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Turism
{    
    class Tours
    {
        public List<Country> counries;  //список стран
        public Country selected;            //выбранная страна
        public List<Discount> discounts;        //список скидок
        public List<Strahovka> strahovka;       //список страховок
        public int season;      //сезон
        
        //загружаем страны
        public void loadCountries()
        {
            counries = MySql.getCountries();
            MySql.getSeasons(counries);  
        }

        //выбираем страну
        public void select(int ind, int seas)
        {
            selected = counries[ind];
            season = seas;
        }

        //загружаем скидки
        public void loadDiscounts()
        {
            discounts = MySql.getDiscountes();
        }

        //загружаем страховку
        public void loadStrahovka()
        {
            strahovka = MySql.getStrahovka();
        }
    }
}
