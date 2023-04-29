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
    /// Логика взаимодействия для HelpBoxSetting.xaml
    /// </summary>
    public partial class HelpBoxSetting : Page
    {
        public HelpBoxSetting()
        {
            InitializeComponent();
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
            {
                HelpBoxService.addHelpText(text.Text);
                text.Text = "";
            }
            else
            {
                MessageBox.Show("Введите данные для добавления справочного материала");
            }

            
        }

        private void SaveChanges2_Click(object sender, RoutedEventArgs e)
        {
            if (text2.Text != "" && text3.Text != "")
            {
                HelpBoxService.editHelpText(Convert.ToInt32(text3.Text), text2.Text);
                text3.Text = "";
                text2.Text = "";
            }
            else
            {
                MessageBox.Show("Введите данные для изменения справочного материала");
            }
        }
    }
}
