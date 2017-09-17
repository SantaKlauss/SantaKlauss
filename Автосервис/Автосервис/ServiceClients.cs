using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Завод
{
   
    public class Clients
    {
            public string FIO;
            int number;

            public Clients(string FIO, int number)
            {
                this.FIO = FIO;
                this.number = number;
            }
            public string GetInfo()
            {
                return this.FIO + " | Номер клиента: " + this.number;
            }
    }
}
