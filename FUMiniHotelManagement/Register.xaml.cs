using FUMiniHotelManagement.BLL.Services;
using FUMiniHotelManagement.DAL.Models;
using Microsoft.IdentityModel.Tokens;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private CustomerService customerService = new();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer()
            {
                EmailAddress = txtEmailAddress.Text,
                Password = txtPassword.Password,
                Telephone = txtTelephone.Text,
                CustomerFullName = txtCustomerFullName.Text,
                CustomerBirthday = dpCustomerBirthday.SelectedDate.HasValue ? DateOnly.FromDateTime(dpCustomerBirthday.SelectedDate.Value) : null,
                CustomerStatus = 2

            };

            if (customer.EmailAddress.IsNullOrEmpty())
            {
                MessageBox.Show("Email can not be empty");
                return;
            }

            var x = customerService.GetCustomers().FirstOrDefault(x => x.EmailAddress.Equals(customer.EmailAddress));

            if (x != null)
            {
                MessageBox.Show("Email is already existed");
                return;
            }

            if (!customer.Password.Equals(txtConfirmPassword.Password))
            {
                MessageBox.Show("Password and Confirm password not match");
                return;
            }

            customerService.AddCustomer(customer);

            MessageBox.Show("Register successfully");
            string verificationCode = new Random().Next(100000, 999999).ToString();

            Email.SendEmail(customer.EmailAddress, "Verification", $"Verification code: {verificationCode}");

            Verify verify = new Verify(verificationCode)
            {
                customer = customer,
            };
            verify.Show();
            this.Close();

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
