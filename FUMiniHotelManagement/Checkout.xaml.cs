using FUMiniHotelManagement.BLL.Services;
using FUMiniHotelManagement.DAL;
using FUMiniHotelManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {
        private BookingReservationService bookingReservationService = new();
        private BookingDetailService bookingDetailService = new();

        private List<RoomInformation> selectedRooms;
        public int customerId { get; set; }

        public Checkout(List<RoomInformation> selectedRooms)
        {
            InitializeComponent();
            
            RoomItemsControl.ItemsSource = selectedRooms;

        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            selectedRooms = RoomItemsControl.ItemsSource as List<RoomInformation>;
            if (selectedRooms == null)
            {
                return;
            }
            decimal? total = 0;
            foreach (var room in selectedRooms)
            {


                if (room.EndDate?.CompareTo(room.StartDate) < 0 || room.EndDate == null || room.StartDate == null)
                {
                    MessageBox.Show("Invalid Start Date or End Date for room: " + room.RoomNumber);
                    return;
                }



                if (room.StartDate?.CompareTo(DateTime.Now) < 0 || room.EndDate?.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("You can not choose time in the past for room: " + room.RoomNumber);
                    return;
                }


                var roomStartDate = DateOnly.FromDateTime(room.StartDate.Value);
                var roomEndDate = DateOnly.FromDateTime(room.EndDate.Value);

                var bookedRoom = bookingDetailService.GetBookingDetails()
                    .FirstOrDefault(x => (x.RoomId == room.RoomId) && x.StartDate.CompareTo(roomEndDate) <= 0 && x.EndDate.CompareTo(roomStartDate) >= 0
                    );

                if (bookedRoom != null)
                {
                    MessageBox.Show($"The room {room.RoomNumber} is booked from {bookedRoom.StartDate} to {bookedRoom.EndDate}");
                    return;
                }


                total += room.RoomPricePerDay * ((room.EndDate.Value.Date - room.StartDate.Value.Date).Days + 1);
            }

            int reservationId = bookingReservationService.AddBookingReservation(new BookingReservation
            {
                BookingDate = DateOnly.FromDateTime(DateTime.Now),
                BookingStatus = 1,
                CustomerId = customerId,
                TotalPrice = total
            });



            foreach (var o in selectedRooms)
            {
                bookingDetailService.AddBookingDetail(new BookingDetail
                {
                    BookingReservationId = reservationId,
                    ActualPrice = o.RoomPricePerDay,
                    EndDate = DateOnly.FromDateTime(o.EndDate.Value),
                    StartDate = DateOnly.FromDateTime(o.StartDate.Value),
                    RoomId = o.RoomId

                });
            }
            this.Close();
            PaymentWindow payment = new PaymentWindow() { reservationId = reservationId};
            payment.Show();

        }
    }
}
