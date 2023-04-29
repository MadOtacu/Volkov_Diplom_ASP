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
using Volkov_Diplom.Models;
using Volkov_Diplom.Services;

namespace Volkov_Diplom
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        List<Question> questions;
        private MainWindow _mainWindow;
        private TextBox _textBox1;
        private TextBox _textBox;
        private RadioButton _radioButton1;
        private RadioButton _radioButton2;
        private RadioButton _radioButton3;
        private CheckBox _checkBox1;
        private CheckBox _checkBox2;
        private CheckBox _checkBox3;
        private Button _nextButton;
        private List<CheckBox> checkBoxes;
        int i = 0;
        int count = 0;

        public Test()
        {
            InitializeComponent();
            questions = QuestionService.getQuestions();
            checkBoxes = new List<CheckBox>();

            textBox1.Text = questions[0].name;
            radioButton1.Content = questions[0].boxAnswer;
            radioButton2.Content = questions[0].boxAnswer2;
            radioButton3.Content = questions[0].boxAnswer3;

            checkBox1.Content = questions[3].boxAnswer;
            checkBox2.Content = questions[3].boxAnswer2;
            checkBox3.Content = questions[3].boxAnswer3;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow = new MainWindow();
            _mainWindow.Show();
            this.Close();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            _textBox1 = this.textBox1;
            _radioButton1 = this.radioButton1;
            _radioButton2 = this.radioButton2;
            _radioButton3 = this.radioButton3;
            _checkBox1 = this.checkBox1;
            _checkBox2 = this.checkBox2;
            _checkBox3 = this.checkBox3;
            _nextButton = this.nextButton;
            _textBox = this.textBox;

            checkBoxes.Add(_checkBox1);
            checkBoxes.Add(_checkBox2);
            checkBoxes.Add(_checkBox3);

            if (i == 0)
            {
                if (_radioButton1.IsChecked == true && _radioButton1.Content.ToString() == questions[0].answer || _radioButton2.IsChecked == true && _radioButton2.Content.ToString() == questions[0].answer || _radioButton3.IsChecked == true && _radioButton3.Content.ToString() == questions[0].answer)
                {
                    count++;
                    //MessageBox.Show(count.ToString());
                }
                _textBox1.Text = questions[1].name;
                _radioButton1.Content = questions[1].boxAnswer;
                _radioButton2.Content = questions[1].boxAnswer2;
                _radioButton3.Content = questions[1].boxAnswer3;
            }
            if (i == 1)
            {
                if (_radioButton1.IsChecked == true && _radioButton1.Content.ToString() == questions[1].answer || _radioButton2.IsChecked == true && _radioButton2.Content.ToString() == questions[1].answer || _radioButton3.IsChecked == true && _radioButton3.Content.ToString() == questions[1].answer)
                {
                    count++;
                    //MessageBox.Show(count.ToString());
                }
                _textBox1.Text = questions[2].name;
                _radioButton1.Content = questions[2].boxAnswer;
                _radioButton2.Content = questions[2].boxAnswer2;
                _radioButton3.Content = questions[2].boxAnswer3;
            }
            if (i == 2)
            {
                if (_radioButton1.IsChecked == true && _radioButton1.Content.ToString() == questions[2].answer || _radioButton2.IsChecked == true && _radioButton2.Content.ToString() == questions[2].answer || _radioButton3.IsChecked == true && _radioButton3.Content.ToString() == questions[2].answer)
                {
                    count++;
                    //MessageBox.Show(count.ToString());
                }
                _textBox1.Text = questions[3].name;
                _radioButton1.Visibility = Visibility.Collapsed;
                _radioButton2.Visibility = Visibility.Collapsed;
                _radioButton3.Visibility = Visibility.Collapsed;
                _checkBox1.Visibility = Visibility.Visible;
                _checkBox2.Visibility = Visibility.Visible;
                _checkBox3.Visibility = Visibility.Visible;
            }
            if (i == 3)
            {
                List<String> answers = questions[3].answer.Split(",").ToList();
                CheckBox checkBoxAnswer1 = new CheckBox();
                CheckBox checkBoxAnswer2 = new CheckBox();

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Content.ToString() == answers[0])
                    {
                        checkBoxAnswer1 = checkBox;
                    }

                    if (checkBox.Content.ToString() == answers[1])
                    {
                        checkBoxAnswer2 = checkBox;
                    }
                }


                if (checkBoxAnswer1.IsChecked == true && checkBoxAnswer2.IsChecked == true)
                {
                    count++;

                   // MessageBox.Show(count.ToString());
                }
                _textBox1.Text = questions[4].name;
                _checkBox1.Content = questions[4].boxAnswer;
                _checkBox2.Content = questions[4].boxAnswer2;
                _checkBox3.Content = questions[4].boxAnswer3;
            }
            if (i == 4)
            {
                List<String> answers = questions[4].answer.Split(",").ToList();
                CheckBox checkBoxAnswer3 = new CheckBox();
                CheckBox checkBoxAnswer4 = new CheckBox();

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Content.ToString() == answers[0])
                    {
                        checkBoxAnswer3 = checkBox;
                    }

                    if (checkBox.Content.ToString() == answers[1])
                    {
                        checkBoxAnswer4 = checkBox;
                    }
                }


                if (checkBoxAnswer3.IsChecked == true && checkBoxAnswer4.IsChecked == true)
                {
                    count++;
                    //MessageBox.Show(count.ToString());
                }
                _textBox1.Text = questions[5].name;
                _checkBox1.Content = questions[5].boxAnswer;
                _checkBox2.Content = questions[5].boxAnswer2;
                _checkBox3.Content = questions[5].boxAnswer3;
            }
            if(i == 5)
            {
                List<String> answers = questions[5].answer.Split(",").ToList();
                CheckBox checkBoxAnswer5 = new CheckBox();
                CheckBox checkBoxAnswer6 = new CheckBox();

                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Content.ToString() == answers[0])
                    {
                        checkBoxAnswer5 = checkBox;
                    }

                    if (checkBox.Content.ToString() == answers[1])
                    {
                        checkBoxAnswer6 = checkBox;
                    }
                }


                if (checkBoxAnswer5.IsChecked == true && checkBoxAnswer6.IsChecked == true)
                {
                    count++;
                    //MessageBox.Show(count.ToString());
                }
                _nextButton.Visibility = Visibility.Collapsed;
                _checkBox1.Visibility = Visibility.Collapsed;
                _checkBox2.Visibility = Visibility.Collapsed;
                _checkBox3.Visibility = Visibility.Collapsed;
                _textBox.Visibility = Visibility.Collapsed;
                _textBox1.Text = $"Ваш счет: {count}/6";


                //MessageBox.Show(count.ToString() + UserService.user.id + UserService.user.resultTest);
                UserService.UpdateResultTestUser(count.ToString());
            }
            i++;
        }
    }
}
