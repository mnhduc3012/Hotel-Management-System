using FUMiniHotelManagement.BLL.Services;
using FUMiniHotelManagement.DAL.Models;
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

namespace FUMiniHotelManagement
{
    /// <summary>
    /// Interaction logic for Verify.xaml
    /// </summary>
    public partial class Verify : Window
    {
        private CustomerService customerService = new();
        private string code;
        public Customer customer { get; set; }
        public Verify(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string verifyCode = txtVerify.Text;

            if (verifyCode.Equals(code))
            {
                

                var x = customerService.GetCustomers().FirstOrDefault(x => x.EmailAddress.Equals(customer.EmailAddress));

                if (x != null)
                {
                    x.CustomerStatus = 1;
                    MessageBox.Show("Verify successfully");
                    customerService.UpdateCustomer(x);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verify fail");
                }

            }
            else
            {
                MessageBox.Show("Verify fail");
            }

        }
    }
}
