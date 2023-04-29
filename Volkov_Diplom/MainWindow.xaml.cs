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

namespace Volkov_Diplom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Spravka _spravka;
        private Test _test;
        private Paint _paint;
        private Autorization _autorization;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            _spravka = new Spravka();
            _spravka.Show();
            this.Close();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            _test = new Test();
            _test.Show();
            this.Close();
        }

        private void creativeButton_Click(object sender, RoutedEventArgs e)
        {
            _paint = new Paint();
            _paint.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GradientStop_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void changeUserButton_Click(object sender, RoutedEventArgs e)
        {
            _autorization = new Autorization();
            _autorization.Show();
            this.Close();
        }
    }
}
