using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Volkov_Diplom
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Autorization _autorization;
        public Registration()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            String login = txtLogin.Text;
            String password = txtPassword.Password;
            String email = txtEmail.Text;
                if (login == "" || password == "" || email == "")
                {
                    MessageBox.Show("Некоторые поля регистрации не заполнены");
                    return;
                }
                else
                {
                    using (ApplicationContext context = new ApplicationContext())
                    {
                        User user = new User(login, password, email);

                        context.Users.Add(user);
                        context.SaveChanges();

                    };

                    MessageBox.Show("Пользователь создан");
                    _autorization = new Autorization();
                    _autorization.Show();
                    this.Close();
                    return;
                }
        }
    }
}
