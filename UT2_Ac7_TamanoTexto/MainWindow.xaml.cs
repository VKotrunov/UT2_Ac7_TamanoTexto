using System;
using System.Windows;
using System.Windows.Controls;

namespace UT2_Ac7_TamanoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            medianoRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontSize = int.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
