using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Marchini.Claudio.Regioni
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, List<Provincia>> provincie = new Dictionary<string, List<Provincia>>();
        public MainWindow()
        {
            CaricaProvincie();
            InitializeComponent();
        }

        private void CaricaProvincie()
        {
            using (var sr = new StreamReader("Dati.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string[] dati = sr.ReadLine().Trim().Split(',');
                    var provincia = new Provincia(dati[1], dati[0]);
                    if (!provincie.ContainsKey(dati[2]))
                        provincie.Add(dati[2], new List<Provincia>());
                    provincie[dati[2]].Add(provincia);
                }
            }
        }

        private void OncmbRegioniSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tmp = sender as ComboBox;
            dtgProvince.ItemsSource = provincie[((ComboBoxItem)tmp.SelectedItem).Content.ToString()];      
        }
    }
}