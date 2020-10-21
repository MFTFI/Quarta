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

namespace Marchini.Claudio.Alloggio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double costo = 15.5;
        private const double val1 = 2000;
        private const double val2 = 700;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBtnAlloggioClick(object sender, RoutedEventArgs e)
        {
            int codice;
            int nPersone;
            double mQuadri;
            Alloggio alloggio;
            if (!(string.IsNullOrEmpty(tbxAlloggioCodice.Text)
              || string.IsNullOrEmpty(tbxAlloggioMQuadri.Text)
              || string.IsNullOrEmpty(tbxAlloggioNPersone.Text)))
            {
                if(int.TryParse(tbxAlloggioCodice.Text, out codice)
                && int.TryParse(tbxAlloggioNPersone.Text, out nPersone)
                && double.TryParse(tbxAlloggioMQuadri.Text, out mQuadri))
                {
                    alloggio = new Alloggio(codice, nPersone, mQuadri);
                    lblAlloggioCostoAcqua.Content = "Costo totale acqua = " + alloggio.CostoAcqua(costo).ToString();
                    lblAlloggioDensita.Content = "Densità in alloggio = " + alloggio.Densita().ToString();
                    lblAlloggioValore.Content = "Valore = " + alloggio.Valore(val1).ToString();
                }
                else
                {
                    MessageBox.Show("Inserire valori validi!");
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori!");
            }
        }

        private void OnBtnVillaClick(object sender, RoutedEventArgs e)
        {
            int codice;
            int nPersone;
            double mQuadri;
            double giardino;
            Villa villa;
            if (!(string.IsNullOrEmpty(tbxVillaCodice.Text)
             || string.IsNullOrEmpty(tbxVillaMQuadri.Text)
             || string.IsNullOrEmpty(tbxVillaNPersone.Text)
             || string.IsNullOrEmpty(tbxVillaMQGiardino.Text)))
            {
                if (int.TryParse(tbxVillaCodice.Text, out codice)
                && int.TryParse(tbxVillaNPersone.Text, out nPersone)
                && double.TryParse(tbxVillaMQuadri.Text, out mQuadri)
                && double.TryParse(tbxVillaMQGiardino.Text, out giardino))
                {
                    villa = new Villa(codice, nPersone, mQuadri, giardino);
                    lblVillaCostoAcqua.Content = "Costo totale acqua = " + villa.CostoAcqua(costo).ToString();
                    lblVillaDensita.Content = "Densità in villa = " + villa.Densita().ToString();
                    lblVillaValore.Content = "Valore = " + villa.Valore(val1, val2).ToString();
                }
                else
                {
                    MessageBox.Show("Inserire valori validi!");
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori!");
            }
        }
    }
}
