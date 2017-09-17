using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAvto
{
    class SQuestion
    {
        public string question;
        public int id;

        public SQuestion(int id, string question)
        {
            this.id = id;
            this.question = question;
        }

        public SQuestion()
        {

        }
    }
}
