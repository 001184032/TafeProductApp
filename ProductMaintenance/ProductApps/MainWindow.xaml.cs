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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cProduct = new Product(Convert.ToDecimal(priceTextBox.Text), Convert.ToInt16(quantityTextBox.Text));
                cProduct.calTotalPayment();
                double TotalPayment = 100.00;
                double deliveryCharge = 25.00;
                double totalCharge = TotalPayment + deliveryCharge;
                totalChargeTextBox.Text = $"${totalCharge:F2}";
                double TotalPayment2 = 100.00;
                double deliveryCharge2 = 5.00;
                double totalCharge2 = TotalPayment2 + TotalPayment2 + deliveryCharge2;
                totalCharge2TextBox.Text = $"${totalCharge2:F2}";
                double GTS = 1.1;
                double totalCharge3 = (TotalPayment + deliveryCharge + deliveryCharge2) * GTS;
                totalCharge3TextBox.Text = $"${totalCharge3:F2}";

                totalPaymentTextBlock.Text = Convert.ToString(cProduct.TotalPayment);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
