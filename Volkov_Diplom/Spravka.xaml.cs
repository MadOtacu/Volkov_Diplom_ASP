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
    /// Логика взаимодействия для Spravka.xaml
    /// </summary>
    public partial class Spravka : Window
    {
        private MainWindow _mainWindow;
        private List<TextBox> _textBoxList;
        private TextBox _textBox1;
        private TextBox _textBox2;
        private TextBox _textBox3;
        private Button _previousButton;
        private Button _nextButton;
        private List<HelpBox> helpBoxes;

        int i = 0;

        public Spravka()
        {
            InitializeComponent();
            helpBoxes = HelpBoxService.getHelpText();
            textBox1.Text = helpBoxes[0].text;
            textBox1.FontSize = 20;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow = new MainWindow();
            _mainWindow.Show();
            this.Close();
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            _textBox1 = this.textBox1;
            
            _previousButton = this.previousButton;
            _nextButton = this.nextButton;
            

            _nextButton.Visibility = Visibility.Visible;
            
            i--;

            textBox1.Text = helpBoxes[i].text;
            if (i == 0)
            {
                _previousButton.Visibility = Visibility.Collapsed;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            _textBox1 = this.textBox1;
            
            _previousButton = this.previousButton;
            _nextButton = this.nextButton;
            

            _previousButton.Visibility = Visibility.Visible;
            
            i++;
            textBox1.Text = helpBoxes[i].text;
            
            if (i == helpBoxes.Count - 1)
            {
                _nextButton.Visibility = Visibility.Collapsed;
            }
        }
    }
}
