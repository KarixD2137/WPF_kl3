using System.Collections.ObjectModel;
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

namespace Kartkowka4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Przepis> Przepisy { get; set; } = new ObservableCollection<Przepis>();

        public List<string> Kategorie { get; set; }  = new List<string> {"napój","przekąska","danie","słodkie"};
        public MainWindow()
        {
            InitializeComponent();
            DodajPrzepisy();
            DataContext = this;
            DataGridComboBoxKategoria.ItemsSource = Kategorie;
        }

        public void DodajPrzepisy()
        {
            Przepisy.Add(new Przepis("Naleśniki", "słodkie", "mąka, jajka, masło, olej, cukier",5,false));
            Przepisy.Add(new Przepis("Herbata", "napój", "woda, torebka herbaty, cytryna, cukier", 1, true));
            Przepisy.Add(new Przepis("Parówki w cieście francuskim", "przekąska", "ciasto francuskie, parówka, ser, ketchup", 12, false));
            Przepisy.Add(new Przepis("Zupa", "danie", "woda, marchewka, kalafior, śmietana", 4, true));
        }

        private void DodajPrzepis(object sender, RoutedEventArgs e)
        {
            int naIleOsob;
            if (int.TryParse(tb_na_ile_osob.Text, out naIleOsob))
            {
                string nazwa = tb_Nazwa.Text;
                string kategoria = cmb_Kategoria.Text;
                string skladniki = tb_skladniki.Text;
                bool czyBezglutenowe = ckb_czy_bezglutenowe.IsChecked == true ? true : false;
                Przepisy.Add(new Przepis(nazwa,kategoria, skladniki, naIleOsob, czyBezglutenowe));
            }
            else
            {
                MessageBox.Show("Ilość osób musi być liczbą całkowitą", "Lista przepisów", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}