﻿using System;
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
        public EditSpectrumWindow()
        {
            InitializeComponent();
        }

        private void button_selectFiles_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "Image Files(*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";

            dlg.ShowDialog();
        }
    }
}
