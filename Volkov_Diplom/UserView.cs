using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Diplom
{
    internal class UserView
    {
        public string login { get; set; }
        public string email { get; set; }
        public string resultTest { get; set; }

        public UserView() { }

        public UserView(string login, string email, string resultTest)
        {
            this.login = login;
            this.email = email;

            this.resultTest = resultTest;
        }
    }
}
