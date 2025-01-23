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

namespace Kartkowka2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oblicz(object sender, RoutedEventArgs e)
        {
            double dlugosc;
            double wynik;
            if (double.TryParse(tb_dlugosc.Text, out dlugosc))
            {
                if (dlugosc > 0)
                {
                    if (kolo.IsChecked == true)
                    {
                        wynik = 2 * Math.PI * dlugosc;
                        MessageBox.Show("Obwód koła to w przybliżeniu " + wynik, "Kalkulator", MessageBoxButton.OK);
                    }
                    else if (kwadrat.IsChecked == true)
                    {
                        wynik = 4 * dlugosc;
                        MessageBox.Show("Obwód kwadratu " + wynik, "Kalkulator", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Zaznacz jedną z opcji", "Kalkulator", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Długość musi być liczbą dodatnią", "Kalkulator", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wpisana wartość nie jest liczbą", "Kalkulator", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
