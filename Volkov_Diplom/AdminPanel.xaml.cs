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

namespace Volkov_Diplom
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void HelpMenu_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("PagesAdminPanel/HelpBoxSetting.xaml", UriKind.RelativeOrAbsolute));
        }

        private void UserMenu_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("PagesAdminPanel/UsersPage.xaml", UriKind.RelativeOrAbsolute));
        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Question_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("PagesAdminPanel/QuestionPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
