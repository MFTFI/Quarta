using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace GesitonaleAzienda
{
    /// <summary>
    /// Logica di interazione per FinestraCreaDipendente.xaml
    /// </summary>
    public partial class FinestraCreaDipendente : Window
    {
        public static event EventHandler<Dipendente> OnFinestraDipendenteBtnCreaClick;

        public FinestraCreaDipendente()
        {
            InitializeComponent();
            for (int i = 1; i < 32; i++)
            {
                CmbGiornoNascita.Items.Add(i);
            }
            for (int i = DateTime.Today.Year; i > 1900; i--)
            {
                CmbAnnoNascita.Items.Add(i);
            }
            foreach (var mese in new DateTimeFormatInfo().MonthNames)
            {
                CmbMeseNascita.Items.Add(mese);
            }
        }

        private void BtnCreaDipendenteClick(object sender, RoutedEventArgs e)
        {
            string nome = TbxNome.Text;
            string cognome = TbxCognome.Text;
            string luogoDiNascita = TbxLuogoNascita.Text;
            int anno = (int)CmbAnnoNascita.SelectedItem;
            int mese = CmbMeseNascita.SelectedIndex + 1;
            int giorno = (int)CmbGiornoNascita.SelectedItem;
            DateTime giornoDiNascita = new DateTime(anno, mese, giorno);
            Dipendente dipendente = new Dipendente(nome, cognome, luogoDiNascita, giornoDiNascita);
            OnFinestraDipendenteBtnCreaClick.Invoke(this, dipendente);
        }
    }
}