using DataGrid;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace DaaGrid
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Studente> studenti = new List<Studente>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBtnCaricaStudentiClick(object sender, RoutedEventArgs e)
        {
            //inizializzazione a 0 per evitare errori su più click
            List<int> error = new List<int>();
            studenti.Clear();
            int lineIndex = 0;

            using (StreamReader sr = new StreamReader("Studenti.csv"))
            {
                while (!sr.EndOfStream)
                {
                    lineIndex++;//trovo la posizione della linea

                    string line = sr.ReadLine();
                    string[] data = line.Split(',');
                    foreach (var item in data)
                        if (string.IsNullOrEmpty(item))
                            error.Add(lineIndex);//se la linea è sbagliata mi salvo la posizione

                    studenti.Add(new Studente(data[0], data[1], data[2])); //aggiungo i dati in uno studente nella lista di studenti
                }
            }

            dtgStudenti.ItemsSource = studenti; //aggiungo gli studenti alla dataGrid
            if (error.Count > 0) //se ci sono degli errori li scrivo in una label
            { 
                string errorMsg;
                errorMsg = $"Ci sono {error.Count} errori alle righe:";
                foreach (var item in error)
                    errorMsg += $" {item},";
                StringBuilder sb = new StringBuilder(errorMsg);
                sb[sb.Length - 1] = '.';
                errorMsg = sb.ToString();
                lblErrori.Content = errorMsg;
            }
        }
    }
}
