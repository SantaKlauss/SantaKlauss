using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Завод
{
    
    public class Details
    {
        public string service;
        public int cost;

        public Details(string service, int cost)
        {
            this.service = service;
            this.cost = cost;
        }

        public string GetService()
        {
            return this.service + " | Стоимость: " + this.cost + " рублей.";
        }
    }
}
