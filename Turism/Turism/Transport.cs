using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism
{
    class Transport
    {
        public int id;      //номер в базе данных
        public string company;      //компания
        public string classType;    //класс
        public float cost;      //цена
        public int country;      //страна
        public string companyName;

        public Transport(int id, string company, string classType, float cost)
        {
            this.id = id;
            this.company = company;
            this.classType = classType;
            this.cost = cost;
        }

    }
}
