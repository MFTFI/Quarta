using System.Collections.Generic;
using System.Windows;

namespace Marchini.Claudio.Villa
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Villa> ville = new List<Villa>();
        List<Alloggio> alloggi = new List<Alloggio>();
        public MainWindow()
        {
            InitializeComponent();
            List<Villa> tmp = Villa.CaricaVille("Data.csv"); //carico le ville da file
            foreach (var casa in tmp) //divido la lista in due liste con le ville e gli alloggi
                if (casa.Giardino == 0)
                    alloggi.Add(casa);
                else
                    ville.Add(casa);
            tmp = null;
            dtgVille.ItemsSource = ville;
            dtgAlloggi.ItemsSource = alloggi;
        }
    }
}