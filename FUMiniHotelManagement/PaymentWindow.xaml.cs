using FUMiniHotelManagement.BLL.Services;
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
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FUMiniHotelManagement
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        private BookingReservationService bookingReservationService = new();
        private BookingDetailService bookingDetailService = new();
        public int reservationId { get; set; }
        public PaymentWindow()
        {
            InitializeComponent();
            
        }




        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = txtCardNumber.Text;
            string cardHolder = txtCartHolder.Text;
            string date = txtDate.Text;

            var reservation = bookingReservationService.GetBookingReservations().FirstOrDefault(x => x.BookingReservationId == reservationId);

            var details = bookingDetailService.GetBookingDetails().Where(x => x.BookingReservationId == reservationId);
            string s = "";

            foreach (var item in details)
            {
                s += $"Room Number: {item.Room.RoomNumber} - Start Date: {item.StartDate} - End Date: {item.EndDate} - SubTotal: {item.SubTotal}\n";
            }

            string body = $"BookingID: {reservation.BookingReservationId}\nBooking Date: {reservation.BookingDate}\n{s}Total Amount: {reservation.TotalPrice}\nBooking Status: {reservation.Status}";

            txtDetails.Text = body;

            if (checkPaymentInfo(cardNumber, cardHolder, date))
            {
                var x = bookingReservationService.GetBookingReservations().FirstOrDefault(x => x.BookingReservationId == reservationId);
                if (x != null)
                {
                    x.BookingStatus = 2;
                    bookingReservationService.UpdateBookingReservation(x);

                    MessageBox.Show("Payment Successfully.\nYour booking is completed.");

                    string subject = "Booking completed";
                                       

                    

                    Email.SendEmail(reservation.Customer.EmailAddress, subject, body);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid payment information.\nPlease try again.");
            }

        }



        private bool checkPaymentInfo(string cardNumber, string cardHolder, string date)
        {

            if (cardNumber.Equals("12345") && cardHolder.Equals("Nguyen Van A") && date.Equals("30/12"))
            {
                return true;
            }

            return false;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var x = bookingReservationService.GetBookingReservations().FirstOrDefault(x => x.BookingReservationId == reservationId);



            MessageBoxResult res = MessageBox.Show("Are you sure you want to cancel this payment?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                if (x != null)
                {
                    x.BookingStatus = 3;
                    bookingReservationService.UpdateBookingReservation(x);
                    this.Close();
                }
            }


        }


       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var reservation = bookingReservationService.GetBookingReservations().FirstOrDefault(x => x.BookingReservationId == reservationId);

            var details = bookingDetailService.GetBookingDetails().Where(x => x.BookingReservationId == reservationId);
            string s = "";
            foreach (var item in details)
            {
                s += $"Room Number: {item.Room.RoomNumber} - Start Date: {item.StartDate} - End Date: {item.EndDate} - SubTotal: {item.SubTotal}\n";
            }

            string body = $"BookingID: {reservation.BookingReservationId}\nBooking Date: {reservation.BookingDate}\n{s}Total Amount: {reservation.TotalPrice}";

            txtDetails.Text = body;
        }
    }



}
