using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;


namespace ProntoSoccorso
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Paziente> pazienti = new List<Paziente>(); //lista di pazienti che devono farsi visitare
        private List<Sintomo> sintomiDisponibili = new List<Sintomo>(); //lista di sintomi che possono essere scelti alla creazione di un nuovo paziente

        public MainWindow()
        {
            InitializeComponent();
            DtgPazienti.ItemsSource = pazienti;

            sintomiDisponibili.Add(new Sintomo("Coronavirus", Gravita.Verde)); //la lista di sintomi viene riempita con degli esempi
            sintomiDisponibili.Add(new Sintomo("Frattura", Gravita.Giallo));
            sintomiDisponibili.Add(new Sintomo("Febbre", Gravita.Rosso));
            sintomiDisponibili.Add(new Sintomo("Malaria", Gravita.Rosso));
            sintomiDisponibili.Add(new Sintomo("Raffreddore", Gravita.Bianco));

            foreach (var sintomo in sintomiDisponibili)
                CmbSintomi.Items.Add(sintomo);
        }

        /// <summary>
        /// Alla premuta del bottone il sintomo nella combobox viene aggiunto nella datagrid se non è già presente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnAggiungiSintomoClick(object sender, RoutedEventArgs e)
        {
            List<Sintomo> sintomi = new List<Sintomo>(); //lista di sintomi nella datagrid
            foreach (var sintomo in DtgSintomi.Items)
            {
                var tmp = sintomo as Sintomo;
                if (tmp != (Sintomo)CmbSintomi.SelectedItem)
                    sintomi.Add(tmp); //se il sintomo è gia presente non viene aggiunto
            }
            sintomi.Add((Sintomo)CmbSintomi.SelectedItem);

            DtgSintomi.ItemsSource = sintomi; //la datagrid va refreshata
        }

        /// <summary>
        /// Se i valori sono corretti, crea un paziente e lo aggiunge alla datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreaPazienteClick(object sender, RoutedEventArgs e)
        {
            string nome = TbxNome.Text;
            string cognome = TbxCognome.Text;
            if (nome == "" || cognome == "")
            {
                MessageBox.Show("Il paziente deve avere un nome e un cognome");
                return;
            }

            List<Sintomo> sintomi = new List<Sintomo>();

            if(DtgSintomi.Items.Count == 0)
            {
                MessageBox.Show("Il paziente deve avere almeno un sintomo");
                return;
            }    

            foreach (Sintomo sintomo in DtgSintomi.Items)
                sintomi.Add(sintomo);
            pazienti.Add(new Paziente(nome, cognome, sintomi));
            DtgPazienti.Items.Refresh();
            DtgSintomi.ItemsSource = null; //quando il paziente viene creato la datagrid con i suoi sintomi viene svuotata
        }

        /// <summary>
        /// Chiama un paziente in ordine di gravità e cronologico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChiamaPazienteClick(object sender, RoutedEventArgs e)
        {
            if (pazienti.Count > 0)
            {
                Paziente pazienteDaChiamare = pazienti[0];

                foreach (var paziente in pazienti)
                {
                    if (paziente.Gravita > pazienteDaChiamare.Gravita)
                        pazienteDaChiamare = paziente; //il ciclo cerca l`elemento con la gravità maggiore tra tutti
                }
                MessageBox.Show($"{pazienteDaChiamare.Nome} {pazienteDaChiamare.Cognome}"); //viene scritto il nome e cognome del paziente da chiamare
                pazienti.Remove(pazienteDaChiamare); //una volta che il paziente è cheiamato viene eliminato dalla coda
                DtgPazienti.Items.Refresh();
            }
            else
                MessageBox.Show("Non ci sono pazienti da chiamare"); //se la lista è vuota non ci sono pazienti da chiamare
        }

        /// <summary>
        /// Al doppio click su una riga appare un popup che mostra tutti i sintomi del paziente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtgPazientiDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SintomiPaziente sP = new SintomiPaziente(pazienti[DtgPazienti.SelectedIndex]);
            sP.ShowDialog();
        }
    }
}