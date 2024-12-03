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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private Customer customer;
        public CustomerWindow(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            CustomerFrame.Navigate(new ListRoom { customerId = customer.CustomerId });
        }


        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            CustomerFrame.Navigate(new Profile { customer = this.customer });
        }



        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No) return;

            LoginWindow l = new LoginWindow();
            l.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            CustomerFrame.Navigate(new BookingManagement { customer = this.customer });
        }

        private void btnRoom_Click(object sender, RoutedEventArgs e)
        {
            CustomerFrame.Navigate(new ListRoom { customerId = customer.CustomerId});
        }
    }
}
