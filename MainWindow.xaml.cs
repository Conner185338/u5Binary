/*
 * Conner Warboys 
 * May 22nd
 * Binary Conversion Code
 * ICS3U
 */
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

namespace u5Binary
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

        private void btnCovert_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            int inputValue = 0;
            int.TryParse(input, out inputValue); //converting string to int
            string binary = Convert.ToString(inputValue, 2); //converts the input to binary
            lblOutput.Content = binary;
        }
    }
}
