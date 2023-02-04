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

namespace Day3_WPF
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

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(firstValue.Text);
            int y = Convert.ToInt32(secondValue.Text);
            int res = x + y;
            result.Text = res.ToString();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(firstValue.Text);
            int y = Convert.ToInt32(secondValue.Text);
            int res = x - y;
            result.Text = res.ToString();
        }
        private void firstValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void multipleButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(firstValue.Text);
            int y = Convert.ToInt32(secondValue.Text);
            int res = x * y;
            result.Text = res.ToString();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(firstValue.Text);
            int y = Convert.ToInt32(secondValue.Text);
            if (y == 0)
            {
                MessageBox.Show("На нуль ділити не можна!");
            }
            else
            {
                double res = x / y;
                result.Text = res.ToString();
            }
            
        }
    }
}