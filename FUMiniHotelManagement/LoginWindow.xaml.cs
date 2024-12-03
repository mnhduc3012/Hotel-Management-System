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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private CustomerService customerService;
        public LoginWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = pwbPassword.Password;

            Customer? c = customerService.Login(email, password);

            if (IsAdmin(email, password))
            {
                AdminWindow mainWindow = new AdminWindow();
                mainWindow.Show();
                this.Close();
            }
            else if (c != null)
            {
                if (c.CustomerStatus == 2)
                {
                    MessageBox.Show("Your account is suspended !",
                "Login Failed",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
                    return;
                }

                CustomerWindow customerWindow = new CustomerWindow(c);
                customerWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password !",
                "Login Failed",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool IsAdmin(string email, string password)
        {
            string adminEmail = "admin";
            string adminPassword = "123";

            if (email.Equals(adminEmail) && password.Equals(adminPassword))
            {
                return true;
            }
            return false;

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnForgot_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.ShowDialog();
        }
    }
}
