using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    class Hotel //отель
    {
        public string name;     //наименование
        public int category;    //категория
        public float cost;      //цена
        public int country;

        public Hotel(string name, int category, float cost, int country)
        {
            this.name = name;
            this.category = category;
            this.cost = cost;
            this.country = country;
        }
    }
}
