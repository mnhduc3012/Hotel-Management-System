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
    /// Interaction logic for EditCustomer.xaml
    /// </summary>
    public partial class EditCustomer : Window
    {
        private CustomerService customerService = new();
        public Customer EditedCustomer { get; set; }
        public EditCustomer()
        {
            InitializeComponent();
        }

        private Customer? GetCustomerForm()
        {
            try
            {
                Customer customer = new Customer
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    CustomerFullName = txtCustomerFullName.Text,
                    Telephone = txtTelephone.Text,
                    EmailAddress = txtEmailAddress.Text,
                    CustomerBirthday = dpCustomerBirthday.SelectedDate.HasValue ? DateOnly.FromDateTime(dpCustomerBirthday.SelectedDate.Value) : null,
                    CustomerStatus = cbxCustomerStatus.SelectedItem.Equals("Active") ? (byte)1 : (byte)2,
                    Password = txtPassword.Text
                };
                return customer;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var cus = GetCustomerForm();
            if (cus == null)
            {
                return;
            }

            var x = customerService.GetCustomers().FirstOrDefault(x => x.CustomerId == cus.CustomerId);

            if (x == null)
            {
                MessageBox.Show("Id is not existed !");
                return;
            }

            customerService.UpdateCustomer(cus);
            this.Close();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var status = new string[] { "Active", "Deactivated" };
            cbxCustomerStatus.ItemsSource = status;

            txtCustomerID.Text = EditedCustomer.CustomerId.ToString();
            txtCustomerFullName.Text = EditedCustomer.CustomerFullName;
            txtTelephone.Text = EditedCustomer.Telephone;
            txtEmailAddress.Text = EditedCustomer.EmailAddress;
            dpCustomerBirthday.Text = EditedCustomer.CustomerBirthday.ToString();
            cbxCustomerStatus.SelectedItem = EditedCustomer.CustomerStatus == 1 ? "Active" : "Deactivated";
            txtPassword.Text = EditedCustomer.Password;
        }

    }
}
