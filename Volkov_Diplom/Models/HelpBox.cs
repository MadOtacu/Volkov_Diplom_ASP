using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Diplom.Models
{
    class HelpBox
    {
        public int id { get; set; }

        public string text { get; set; }


        public HelpBox() { }


        public HelpBox(string text) 
        {
            this.text = text;
        }


    }
}
