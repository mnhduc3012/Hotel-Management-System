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
    /// Interaction logic for BookingManagement.xaml
    /// </summary>
    public partial class BookingManagement : Page
    {
        private BookingReservationService reservationService = new();

        public Customer? customer { get; set; }
        public BookingManagement()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadFilter();
            LoadData();
        }

        private void LoadFilter()
        {
            var status = reservationService.GetBookingReservations().Select(x => new { x.BookingStatus, x.Status }).Distinct().ToList();

            status.Insert(0, new { BookingStatus = (byte?)0, Status = "All" });

            cbxFilter.ItemsSource = status;
            cbxFilter.DisplayMemberPath = "Status";
            cbxFilter.SelectedValuePath = "BookingStatus";
            cbxFilter.SelectedIndex = 0;


        }

        private void LoadData()
        {
            var bookings = reservationService.GetBookingReservations();

            if (customer != null)
            {
                bookings = bookings.Where(x=>x.CustomerId == customer.CustomerId).ToList();
            }

            dgvDisplay.ItemsSource = null;
            dgvDisplay.ItemsSource = bookings;
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            BookingReservation? selected = dgvDisplay.SelectedItem as BookingReservation;

            if (selected == null)
            {
                MessageBox.Show("Please choose a reservation !");
                return;
            }

            BookingDetailWindow b = new BookingDetailWindow { selectedReservation = selected };
            b.ShowDialog();
            LoadData();

        }

        private void cbxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int bookingStatus = int.Parse( cbxFilter.SelectedValue.ToString());

            var bookings = reservationService.GetBookingReservations();

            if (customer != null)
            {
                bookings = bookings.Where(x => x.CustomerId == customer.CustomerId).ToList();
            }

            if(bookingStatus != 0)
            {
                bookings = bookings.Where(x => x.BookingStatus == bookingStatus).ToList();
            }

            dgvDisplay.ItemsSource = null;
            dgvDisplay.ItemsSource = bookings;
        }
    }
}
