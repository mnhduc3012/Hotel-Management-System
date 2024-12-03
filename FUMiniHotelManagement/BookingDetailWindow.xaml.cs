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
    /// Interaction logic for BookingDetailWindow.xaml
    /// </summary>
    public partial class BookingDetailWindow : Window
    {
        private BookingDetailService _bookingDetailService = new();
        public BookingReservation selectedReservation { get; set; }
        public BookingDetailWindow()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            txtBookingId.Text = selectedReservation.BookingReservationId.ToString();
            txtBookingDate.Text = selectedReservation.BookingDate.ToString();
            txtStatus.Text = selectedReservation.Status.ToString();
            txtCustomerName.Text = selectedReservation.Customer.CustomerFullName.ToString();
            txtPhone.Text = selectedReservation.Customer.Telephone.ToString();
            txtEmail.Text = selectedReservation.Customer.EmailAddress.ToString();
            txtGrandTotal.Text = "$" + selectedReservation.TotalPrice.ToString();

            var bookingDetail = _bookingDetailService.GetBookingDetails().Where(x => x.BookingReservationId == selectedReservation.BookingReservationId);
            dgvDisplay.ItemsSource = bookingDetail;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
