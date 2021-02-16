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
using System.IO;

namespace Marchini.Claudio.VilleModali
{
    /// <summary>
    /// Logica di interazione per FinestraAggiungi.xaml
    /// </summary>
    public partial class FinestraAggiungi : Window
    {
        public FinestraAggiungi()
        {
            InitializeComponent();
        }

        private void BtnAnnulla_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r =  MessageBox.Show("Davvero chiudere la finestra?");
            if(!(r == MessageBoxResult.OK))
                Close();
        }

        private void BtnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            Villa villa;

            int id, numeroPersone;
            float metri, costoAcqua, metriGiardino = 0.0f;
            bool corretto = true;
            corretto = int.TryParse(TbxId.Text, out id) && corretto;
            corretto = int.TryParse(TbxNPerosne.Text, out numeroPersone) && corretto;
            corretto = float.TryParse(TbxMetri.Text, out metri) && corretto;
            corretto = float.TryParse(TbxCostoAcqua.Text, out costoAcqua) && corretto;
            if ((bool)RdbVilla.IsChecked)
            {
                float.TryParse(TbxMetriGiardino.Text, out metriGiardino);
                villa = new Villa(id, numeroPersone, metri, costoAcqua, metriGiardino);
            }
            else
                villa = new Villa(id, numeroPersone, metri, costoAcqua, 0.0f); ;

            if (corretto)
            {
                using (StreamWriter sw = new StreamWriter("Input.csv", true))
                {
                    string linea = TbxId.Text.Replace(',', '.') + "," + TbxNPerosne.Text.Replace(',', '.') + "," + TbxMetri.Text.Replace(',', '.') + "," + TbxCostoAcqua.Text.Replace(',', '.') + ",";
                    if (metriGiardino != 0.0f)
                        linea += TbxMetriGiardino.Text.Replace(',', '.');
                    else
                        linea += 0;
                    sw.WriteLine(linea);
                }
            }
            else
            {  
                MessageBox.Show("I valori inseriti sono errati");
                return;
            }

            var tmp = Owner as MainWindow;
            tmp.AggiornaDataGrid();

            Close();
        }

        private void Rdb_Checked(object sender, RoutedEventArgs e)
        { 
            TbxMetriGiardino.IsEnabled = (bool)RdbVilla.IsChecked;
            LblMetriGiardino.IsEnabled = (bool)RdbVilla.IsChecked;
        }
    }
}
