using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Diplom.Models
{
    class Question
    {
        public int id { get; set; }

        public string answer { get; set; }

        public string name { get; set; }

        public string boxAnswer { get; set; }
        public string boxAnswer2 { get; set; }
        public string boxAnswer3 { get; set; }

        public Question() { }


        public Question(string answer)
        {
            this.answer = answer;
        }

    }
}
