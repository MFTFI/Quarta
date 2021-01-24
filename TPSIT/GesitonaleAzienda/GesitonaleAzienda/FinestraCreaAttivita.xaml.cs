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
using System.Windows.Shapes;
using System.Globalization;

namespace GesitonaleAzienda
{
    /// <summary>
    /// Logica di interazione per FinestraCreaAttivita.xaml
    /// </summary>
    public partial class FinestraCreaAttivita : Window
    {
        private Contratto contratto;
        public static event EventHandler<Contratto> OnFinestraAttivitaBtnCreaClick;

        public FinestraCreaAttivita()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                CmbData.Items.Add(DateTime.Today.AddDays(-i));
            }
            int ora;
            for (int i = 0; i < 48; i++)
            {
                ora = i / 2;
                CmbOraAttivita.Items.Add(ora.ToString() + (i % 2 == 0 ? " : 00" : " : 30"));
            }
            for (int i = 1; i < 100; i++)
            {
                CmbNOre.Items.Add(i.ToString());
            }
        }

        //~FinestraCreaAttivita()
        //{
        //    OnFinestraAttivitaClosing.Invoke(this, contratto);
        //}

        private void BtnCreaAttivitaClick(object sender, RoutedEventArgs e)
        {
            string ora;
            string nOre;
            try
            {
                DateTime giorno = DateTime.Parse(CmbData.Text);
                ora = CmbOraAttivita.Text;
                nOre = CmbNOre.Text;
                DateTime data = new DateTime(giorno.Year, giorno.Month, giorno.Day, int.Parse(ora.Split(':')[0]), int.Parse(ora.Split(':')[1]), 0);
                contratto = new Contratto(data, float.Parse(CmbNOre.Text), TbxDescrizioneAttività.Text);
                OnFinestraAttivitaBtnCreaClick.Invoke(this, contratto);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
