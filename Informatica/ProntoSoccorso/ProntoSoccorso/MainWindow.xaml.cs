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

namespace ProntoSoccorso
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Paziente> pazienti = new List<Paziente>();
        private List<Sintomo> sintomi = new List<Sintomo>();

        public MainWindow()
        {
            InitializeComponent();
            DtdPazienti.ItemsSource = pazienti;

            sintomi.Add(new Sintomo("CoronaVairus", Gravita.Verde));
            sintomi.Add(new Sintomo("Sifilide", Gravita.Giallo));
            sintomi.Add(new Sintomo("Febbre", Gravita.Rosso));
            sintomi.Add(new Sintomo("Malaria", Gravita.Rosso));
            sintomi.Add(new Sintomo("Gonorrea", Gravita.Bianco));

            foreach (var sintomo in sintomi)
                CmbSintomi.Items.Add(sintomo);
        }

        private void BtnAggiungiSintomoClick(object sender, RoutedEventArgs e)
        {
            List<Sintomo> sooos = new List<Sintomo>();
            foreach (var sintomo in DtgSintomi.Items)
            {
                var tmp = sintomo as Sintomo;
                if (tmp != (Sintomo)CmbSintomi.SelectedItem)
                    sooos.Add(tmp);
            }
            sooos.Add((Sintomo)CmbSintomi.SelectedItem);

            DtgSintomi.ItemsSource = sooos;
        }

        private void BtnCreaPazienteClick(object sender, RoutedEventArgs e)
        {
            string nome = TbxNome.Text;
            string cognome = TbxCognome.Text;
            List<Sintomo> sintomi = new List<Sintomo>();
            foreach (Sintomo sintomo in DtgSintomi.Items)
                sintomi.Add(sintomo);
            pazienti.Add(new Paziente(nome, cognome, sintomi));
            DtdPazienti.Items.Refresh();
            DtgSintomi.ItemsSource = null;
        }

        private void BtnChiamaPazienteClick(object sender, RoutedEventArgs e)
        {
            if (pazienti.Count > 0)
            {
                Paziente pazienteDaChiamare = pazienti[0];

                foreach (var paziente in pazienti)
                {
                    if (paziente.Gravita > pazienteDaChiamare.Gravita)
                        pazienteDaChiamare = paziente;
                }
                MessageBox.Show($"{pazienteDaChiamare.Nome} {pazienteDaChiamare.Cognome}");
                pazienti.Remove(pazienteDaChiamare);
                DtdPazienti.Items.Refresh();
            }
            else
                MessageBox.Show("Non ci sono pazienti da chiamare");
        }
    }
}