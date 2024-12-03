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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        private CustomerService customerService = new();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;

            if (email.IsNullOrEmpty())
            {
                MessageBox.Show("Email can not be empty.");
                return;

            }

            var x = customerService.GetCustomers().FirstOrDefault(x => x.EmailAddress.Equals(email));


            if (x != null)
            {
                Email.SendEmail(email, "Forgot password", $"Your password: {x.Password}");
                MessageBox.Show("Password has been sent to your email");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email not exist");
            }
        }
    }
}
