using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    class Strahovka
    {
        public string name; //наименование пакета страхования
        public float cost;  //цена

        public Strahovka(string name, float cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
