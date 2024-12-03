using FUMiniHotelManagement.BLL.Services;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUMiniHotelManagement
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        private BookingDetailService bookingDetailService = new();
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Load()
        {
            var data = bookingDetailService.GetBookingDetails().Where(x => x.BookingReservation.BookingStatus == 2).ToList();
            dgvDisplay.ItemsSource = data;

            decimal? total = 0;
            foreach (var o in data)
            {
                total += o.SubTotal;
            }
            txtTotal.Text = total.ToString();

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

            if (dpkFrom.Text.IsNullOrEmpty() && dpkTo.Text.IsNullOrEmpty())
            {
                Load();
            }
            else if ( dpkFrom.Text.IsNullOrEmpty() || dpkTo.Text.IsNullOrEmpty() || (DateOnly.Parse(dpkFrom.Text).CompareTo(DateOnly.Parse(dpkTo.Text))) > 0)
            {
                MessageBox.Show("Invalid input !");
                return;
            }
            else
            {
                var data = bookingDetailService.GenerateReport(DateOnly.Parse(dpkFrom.Text), DateOnly.Parse(dpkTo.Text));
                dgvDisplay.ItemsSource = data;
                decimal? total = 0;
                foreach (var o in data)
                {
                    total += o.SubTotal;
                }
                txtTotal.Text = total.ToString();
            }


        }
    }
}
