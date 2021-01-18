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
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
