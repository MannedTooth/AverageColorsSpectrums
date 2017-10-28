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
            EditSpectrumWindow esw = new EditSpectrumWindow();
            if (esw.ShowDialog() == true)
            {
                label1.Content = esw.textBox_spectrumName.Text;
            }
        }

        private void button_editSectrum_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
