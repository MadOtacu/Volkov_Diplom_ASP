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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace Volkov_Diplom
{
    /// <summary>
    /// Логика взаимодействия для Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        private MainWindow _mainWindow;

        public Paint()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow = new MainWindow();
            _mainWindow.Show();
            this.Close();
        }

        private async void showButton_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri("D:/Work/Егор/Volkov_Diplom/Volkov_Diplom/Volkov_Diplom/Images/BigBear.jpg", UriKind.Absolute));
            this.inkСanvas.Background = myBrush;
            this.showButton.Visibility = Visibility.Collapsed;
            this.hideButton.Visibility = Visibility.Visible;

            /*BitmapImage fff = new BitmapImage(new Uri("D:/Work/Егор/Volkov_Diplom/Volkov_Diplom/Volkov_Diplom/Images/BigBear.jpg", UriKind.Absolute));

            Byte[] buffer = BufferFromImage(fff);*/

            /*Image image = new Image();
            image.Source = new BitmapImage(new Uri("D:/Work/Егор/Volkov_Diplom/Volkov_Diplom/Volkov_Diplom/Images/BigBear.jpg", UriKind.Absolute));

            using (MemoryStream ms = new MemoryStream())
            {

                
            }*/
            /*foreach (Byte f in buffer)
            {
                MessageBox.Show(f.ToString());
            }*/
            
        }

        private void hideButton_Click(object sender, RoutedEventArgs e)
        {
            inkСanvas.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, (byte)255, (byte)255, (byte)255)); ;
            hideButton.Visibility = Visibility.Collapsed;
            showButton.Visibility = Visibility.Visible;
        }


        public Byte[] BufferFromImage(BitmapImage imageSource)
        {
            Stream stream = imageSource.StreamSource;
            Byte[] buffer = null;
            if (stream != null && stream.Length > 0)
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    buffer = br.ReadBytes((Int32)stream.Length);
                }
            }

            return buffer;
        }
    }
}
