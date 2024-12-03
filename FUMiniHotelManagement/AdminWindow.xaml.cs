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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            AdminFrame.Navigate(new Dashboard());

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

        private void btnRoom_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new RoomManagement());
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new CustomerManagement());
        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new BookingManagement());
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new Dashboard());
        }

        private void btnRoomType_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new RoomTypeManagement());
        }
    }
}
