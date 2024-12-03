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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUMiniHotelManagement
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Customer? customer { get; set; }
        private CustomerService customerService = new();
        public Profile()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var c = GetCustomerForm();
            if (c == null)
            {
                MessageBox.Show("Invalid input !");
                return;
            }
            customerService.UpdateCustomer(c);
            MessageBox.Show("Update successfully");
            Load();
        }
        private Customer? GetCustomerForm()
        {
            try
            {
                Customer c = new Customer
                {
                    CustomerId = customer.CustomerId,
                    CustomerFullName = txtCustomerFullName.Text,
                    Telephone = txtTelephone.Text,
                    EmailAddress = txtEmailAddress.Text,
                    CustomerBirthday = dpCustomerBirthday.SelectedDate.HasValue ? DateOnly.FromDateTime(dpCustomerBirthday.SelectedDate.Value) : null,
                    CustomerStatus = customer.CustomerStatus,
                    Password = txtPassword.Text
                }; ;
                return c;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Load()
        {
            var c = customerService.GetCustomers().FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            txtCustomerFullName.Text = c.CustomerFullName;
            txtTelephone.Text = c.Telephone;
            txtEmailAddress.Text = c.EmailAddress;
            dpCustomerBirthday.Text = c.CustomerBirthday.ToString();
            txtPassword.Text = c.Password;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
