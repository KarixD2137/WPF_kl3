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

namespace Kartkowka3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zdjecie> Zdjecia = new List<Zdjecie>();
        public MainWindow()
        {
            InitializeComponent();

            Zdjecia.Add(new Zdjecie("0.png"));
            Zdjecia.Add(new Zdjecie("1.png"));
            Zdjecia.Add(new Zdjecie("2.png"));
            Zdjecia.Add(new Zdjecie("3.png"));
        }

        private void PokazZdjęcie(object sender, RoutedEventArgs e)
        {
            int idZdjecia;
            switch (cb_zdjecie.Text)
            {
                case "Kwadrat":
                    idZdjecia = 0;
                    break;
                case "Trójkąt":
                    idZdjecia = 1;
                    break;
                case "Koło":
                    idZdjecia = 2;
                    break;
                case "Gwiazda":
                    idZdjecia = 3;
                    break;
                default:
                    idZdjecia = -1;
                    break;
            }
            if (idZdjecia != -1)
            {
                img_zdjecie.Source = new BitmapImage(new Uri(Zdjecia.ElementAt(idZdjecia).sciezka, UriKind.Relative));
                Zdjecia.ElementAt(idZdjecia).liczbaWyswietlen++;
                lbl_wyswietlenia.Content = Zdjecia.ElementAt(idZdjecia).liczbaWyswietlen.ToString();
            }
        }
    }
}
