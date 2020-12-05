using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Auto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<AutoUsata> autoUsate = new List<AutoUsata>();
        List<Automobile> automobili = new List<Automobile>();

        public MainWindow()
        {
            InitializeComponent();          
        }

        private void OnRbtnNuovaChecked(object sender, RoutedEventArgs e)
        {
            //await Task.Run(() => { CbxFiltro.ItemsSource = nomiProprieta; });
            DtgAuto.ItemsSource = automobili;
        }

        private void OnRbtnUsataChecked(object sender, RoutedEventArgs e)
        {
            DtgAuto.ItemsSource = autoUsate;
        }

        private void OnRbtnQualsiasiChecked(object sender, RoutedEventArgs e)
        {
            if (Automobile.CaricaDaFile("Auto.csv", out automobili) && Automobile.CaricaDaFile("Auto.csv", out autoUsate))
            {
                List<Automobile> auto = new List<Automobile>();
                foreach (var tmp in autoUsate)
                    auto.Add(tmp);
                foreach (var tmp in automobili)
                    auto.Add(tmp);
                DtgAuto.ItemsSource = auto;
            }
        }
    }
}
