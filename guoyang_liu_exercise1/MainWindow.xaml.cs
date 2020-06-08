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

namespace guoyang_liu_exercise1
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            string patientName = null;
            try
            {
                if (cmbProvince.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose a province");
                    return;
                }
                if (cekFloss.IsChecked == true)
                {
                    result += 20;
                }
                if (cekFill.IsChecked == true)
                {
                    result += 75;
                }
                if (cekRoot.IsChecked == true)
                {
                    result += 150;
                }
                if (rdoSenior.IsChecked == true)
                {
                    result = result * 0.9;
                }
                else if (rdoKids.IsChecked == true)
                {
                    result = result * 0.85;
                }
                else
                {
                    result = result;
                }

                if (((ComboBoxItem)cmbProvince.SelectedItem).Content.ToString() == "Alberta")
                {
                    result = result * 1.07;
                }
                else if (((ComboBoxItem)cmbProvince.SelectedItem).Content.ToString() == "Ontario")
                {
                    result = result * 1.13;
                }
                else if (((ComboBoxItem)cmbProvince.SelectedItem).Content.ToString() == "Quebec")
                {
                    result = result * 1.06;
                }
                patientName = txtName.Text;
                txtResult.Text = "The patient is "+ patientName +" and his/her total charge is: " + result.ToString("F");


            }
            catch (ArgumentException error)
            {
                txtResult.Text = error.ToString();
            }
        }
    }
}
