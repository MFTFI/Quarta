using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Marchini.Claudio.VilleModali
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AggiornaDataGrid();
        }

        public void AggiornaDataGrid()
        {
            DtgVille.ItemsSource = CaricaDaFile<Villa>("Input.csv");
            DtgAlloggi.ItemsSource = CaricaDaFile<Alloggio>("Input.csv");
        }

        public List<T> CaricaDaFile<T>(string nomeFile) /*where T : Villa, Alloggio*/
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            List<T> dati = new List<T>();
            try
            {
                using (StreamReader sr = new StreamReader(nomeFile))
                {
                    sr.ReadLine(); //la prima riga riguarda l`utente
                    while (!sr.EndOfStream)
                    {
                        string[] valori = sr.ReadLine().Trim().Split(',');

                        int id, numeroPersone;
                        float metri, costoAcqua, metriGiardino;

                        int.TryParse(valori[0], out id);
                        int.TryParse(valori[1], out numeroPersone);
                        float.TryParse(valori[2], NumberStyles.Float, nfi, out metri);
                        float.TryParse(valori[3], NumberStyles.Float, nfi, out costoAcqua);
                        float.TryParse(valori[4], NumberStyles.Float, nfi, out metriGiardino);

                        if (typeof(T) == typeof(Alloggio) && metriGiardino == 0)
                        {
                            T tmp = (T)Activator.CreateInstance(typeof(T), id, numeroPersone, metri, costoAcqua);
                            dati.Add(tmp);
                        }
                        else if (typeof(T) == typeof(Villa) && metriGiardino != 0)
                        {
                            T tmp = (T)Activator.CreateInstance(typeof(T), id, numeroPersone, metri, costoAcqua, metriGiardino);
                            dati.Add(tmp);                
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dati;
        }

        private void BtnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            var finestra = new FinestraAggiungi();
            finestra.Owner = this;
            finestra.ShowDialog();
        }

        private void DtgAlloggi_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var finestra = new FinestraAggiungi();
            finestra.Owner = this;
            finestra.Title = "Modifica contenuto";
            finestra.BtnAggiungi.Content = "Modifica";
            finestra.ShowDialog();
        }

        private void DtgVille_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var finestra = new FinestraAggiungi();
            finestra.Owner = this;
            finestra.Title = "Modifica contenuto";
            finestra.BtnAggiungi.Content = "Modifica";
            finestra.RdbVilla.IsChecked = true;
            finestra.ShowDialog();
        }
    }
}
