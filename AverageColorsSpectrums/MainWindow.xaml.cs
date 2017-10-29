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

namespace AverageColorsSpectrums
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_addSpectrum_Click(object sender, RoutedEventArgs e)
        {
            EditSpectrumWindow esw = new EditSpectrumWindow("add");
            esw.ShowDialog();
        }

        private void button_editSectrum_Click(object sender, RoutedEventArgs e)
        {
            EditSpectrumWindow esw = new EditSpectrumWindow("edit");
            esw.ShowDialog();
        }

        private void button_removeSpectrum_Click(object sender, RoutedEventArgs e)
        {
            listView_spectrumList.Items.RemoveAt(listView_spectrumList.SelectedIndex);
        }

        private void button_generateSpectrums_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
