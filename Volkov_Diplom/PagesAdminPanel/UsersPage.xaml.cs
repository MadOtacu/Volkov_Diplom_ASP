using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Volkov_Diplom.Services;

namespace Volkov_Diplom.PagesAdminPanel
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            List<UserView> userList = new List<UserView>();
            foreach (var user in UserService.getUsers())
            {
                userList.Add(new UserView(user.login, user.email, user.resultTest));
            }
            foreach (var item in userList)
            {
                users.Items.Add(item);
            }
        }
    }
}
