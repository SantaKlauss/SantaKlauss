using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    class Discount  //скидка
    {
        public string name; //наименование
        public float cost;  //размер в процентах

        public Discount(string name, float cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
