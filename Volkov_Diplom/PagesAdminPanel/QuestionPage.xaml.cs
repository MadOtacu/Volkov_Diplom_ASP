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
    /// Логика взаимодействия для QuestionPage.xaml
    /// </summary>
    public partial class QuestionPage : Page
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        private void EditQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (idQuestion.Text != "" && nameQuestion.Text != "" && textbox1.Text != "" && textbox2.Text != "" && textbox3.Text != "")
            {
                QuestionService.editBodyQuestions(Convert.ToInt32(idQuestion.Text), nameQuestion.Text,answer.Text, textbox1.Text, textbox2.Text, textbox3.Text);

                idQuestion.Text = "";
                nameQuestion.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";

            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
