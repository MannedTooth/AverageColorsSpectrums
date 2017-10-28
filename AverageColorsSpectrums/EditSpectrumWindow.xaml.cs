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

namespace AverageColorsSpectrums
{
    /// <summary>
    /// Interaction logic for EditSpectrumWindow.xaml
    /// </summary>
    public partial class EditSpectrumWindow : Window
    {
        Spectrum spectrum = new Spectrum();
        string mode;

        public EditSpectrumWindow(string _mode)
        {
            InitializeComponent();
            mode = _mode;
            if (mode == "edit")
            {
                spectrum = (Spectrum)((MainWindow)Application.Current.MainWindow).listView_spectrumList.SelectedItem;
                label_numberFilesSelected.Content = spectrum.fileNames.Count().ToString() + " file(s) selected";
                textBox_spectrumName.Text = spectrum.name;
            }
        }

        private void button_selectFiles_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "Image Files(*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == true)
            {
                spectrum.fileNames = dlg.FileNames;
                label_numberFilesSelected.Content = spectrum.fileNames.Count().ToString() + " file(s) selected";
            }
        }

        private void button_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_spectrumName.Text == "")
            {
                System.Windows.MessageBox.Show("You must enter a name for this spectrum!");
            }
            else
            {
                spectrum.name = textBox_spectrumName.Text;
                spectrum.numberOfFiles = spectrum.fileNames.Count();
                if (mode == "add")
                {
                    ((MainWindow)Application.Current.MainWindow).listView_spectrumList.Items.Add(spectrum);
                }
                else if (mode == "edit")
                {
                    ((MainWindow)Application.Current.MainWindow).listView_spectrumList.SelectedItem = spectrum;
                    ((MainWindow)Application.Current.MainWindow).listView_spectrumList.Items.Refresh();
                }
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
