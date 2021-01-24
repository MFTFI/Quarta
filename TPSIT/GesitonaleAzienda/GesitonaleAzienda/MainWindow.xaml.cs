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

namespace GesitonaleAzienda
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contratto> contratti = new List<Contratto>();
        List<Dipendente> dipendenti = new List<Dipendente>() /*{ new Dipendente("mario", "rossi", "rimini", DateTime.Now), new Dipendente("luigi", "rossi", "rimini", DateTime.Now) }*/;

        public MainWindow()
        {
            InitializeComponent();
            FinestraCreaAttivita.OnFinestraAttivitaBtnCreaClick += OttieniContratto;
            FinestraCreaDipendente.OnFinestraDipendenteBtnCreaClick += OttieniDipendente;
            DtgContratti.ItemsSource = contratti;
            DtgDipendenti.ItemsSource = dipendenti;
        }

        private void BtnAggiungiDipendenteClick(object sender, RoutedEventArgs e)
        {
            FinestraCreaDipendente window = new FinestraCreaDipendente();
            window.Owner = this;
            window.ShowDialog();
        }

        private void BtnAggiungiAttivitaClick(object sender, RoutedEventArgs e)
        {
            FinestraCreaAttivita window = new FinestraCreaAttivita();
            window.Owner = this;
            window.ShowDialog();
        }

        private void OttieniContratto(object sender, Contratto e)
        {
            if (e != null)
            {
                if (DtgDipendenti.SelectedItem != null)
                    (DtgDipendenti.SelectedItem as Dipendente).Contratti.Add(e);
                else
                    MessageBox.Show("Selezionare nella combo box un dipendente a cui aggiungere un attivita");
            }
            DtgContratti.Items.Refresh();
        }

        private void OttieniDipendente(object sender, Dipendente e)
        {
            if (e != null)
                dipendenti.Add(e);
            DtgDipendenti.Items.Refresh();
        }

        private void CmbAttivitaModificaClick(object sender, RoutedEventArgs e)
        {
            FinestraCreaAttivita window = new FinestraCreaAttivita();
            window.Owner = this;
            window.Show();
        }

        private void CmbDipendenteModificaClick(object sender, RoutedEventArgs e)
        {
            FinestraCreaAttivita window = new FinestraCreaAttivita();
            window.Owner = this;
            window.Show();
        }

        private void CmbAttivitaEliminaClick(object sender, RoutedEventArgs e)
        {
            if (DtgContratti.SelectedIndex != -1)
                contratti.RemoveAt(DtgContratti.SelectedIndex);
            DtgContratti.Items.Refresh();
        }

        private void CmbDipendenteEliminaClick(object sender, RoutedEventArgs e)
        {
            if (DtgDipendenti.SelectedIndex != -1)
                dipendenti.RemoveAt(DtgDipendenti.SelectedIndex);
            DtgDipendenti.Items.Refresh();
        }

        private void DtgDipendentiSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.RemovedItems.Count == 0)
                DtgContratti.ItemsSource = (DtgDipendenti.SelectedItem as Dipendente).Contratti;
        }
    }
}