using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;


namespace styczen_2024
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Photo.Source = new BitmapImage(new Uri("Images/000-zdjecie.jpg", UriKind.Relative));
            Fingerprint.Source = new BitmapImage(new Uri("Images/000-odcisk.jpg", UriKind.Relative));
        }

        private void ChangeImage(object sender, RoutedEventArgs e)
        {
            string number = Number.Text;
            string photoSource = $"Images/{number}-zdjecie.jpg";
            string fingerprintSource = $"Images/{number}-odcisk.jpg";

            Photo.Source = new BitmapImage(new Uri(photoSource, UriKind.Relative));
            Fingerprint.Source = new BitmapImage(new Uri(fingerprintSource, UriKind.Relative));
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string surname = Surname.Text;
            string color = "";
            
            if(BlueEyes.IsChecked == true)
            {
                 color = "niebieskie";
            }else if(GreenEyes.IsChecked == true)
            {
                 color = "zielone";
            }else if(BrownEyes.IsChecked == true)
            {
                 color = "brązowe";
            }
            if(name.Length>0 &&  surname.Length>0 && color.Length>0) {
                MessageBox.Show($"{name} {surname} kolor oczu {color}");
        }
    }
}
    }
