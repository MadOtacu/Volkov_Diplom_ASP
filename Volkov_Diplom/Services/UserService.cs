using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Diplom.Services
{
    static class UserService
    {
        public static User user { get; set; }

        public static List<User> getUsers()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                List<User> users = context.Users.ToList();

                return users;
            }

        }


        public static void  UpdateResultTestUser(string resultTest)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                User userg = context.Users.Find(user.id);

                userg.resultTest = resultTest;

                context.Users.Update(userg);
                context.SaveChanges();
            }
                


        }
    }
}
