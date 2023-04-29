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
using System.Windows.Shapes;
using Volkov_Diplom.Services;

namespace Volkov_Diplom
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        private Registration _registration;
        private MainWindow _mainWindow;

        public Autorization()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            _registration = new Registration();
            _registration.Show();
            this.Close();

        }

        private void autorization_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            {
                var login = txtLogin.Text;
                var password = txtPassword.Password;


                using (ApplicationContext context = new ApplicationContext())
                {
                    bool userfound = context.Users.Any(user => user.login == login && user.password == password);

                    if (userfound)
                    {
                        _mainWindow = new MainWindow();
                        _mainWindow.Show();
                        this.Close();

                         

                        try
                        {
                            User user = context.Users.FirstOrDefault(user => user.login == login && user.password == password);
                            UserService.user = user;
                            //MessageBox.Show($"{UserService.user.login}");


                            if (user.login == "admin" && user.password == "admin")
                            {
                                AdminPanel adminPanel = new AdminPanel();

                                adminPanel.Show();
                            }
                        }
                        catch (System.InvalidOperationException)
                        {
                            MessageBox.Show("Админ не найден");
                        }
                        



                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден!");

                    }
                }
            }
        }
    }
}
