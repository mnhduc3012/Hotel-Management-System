using FUMiniHotelManagement.BLL.Services;
using FUMiniHotelManagement.DAL.Models;
using Microsoft.IdentityModel.Tokens;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUMiniHotelManagement
{
    /// <summary>
    /// Interaction logic for ListRoom.xaml
    /// </summary>
    public partial class ListRoom : Page
    {


        private RoomInformationService roomInformationService = new();
        private RoomTypeService roomTypeService = new();
        private BookingDetailService bookingDetailService = new();

        public int customerId { get; set; }
        public ListRoom()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var rooms = roomInformationService.GetRoomInformations();
            var roomsObservable = new ObservableCollection<RoomInformation>(rooms);
            dgvDisplay.ItemsSource = roomsObservable;
        }

        private void LoadCbxRoomType()
        {
            var roomType = roomTypeService.GetRoomTypes();
            roomType.Insert(0, new RoomType { RoomTypeName = "All", RoomTypeId = 0 });
            cbxRoomType.ItemsSource = roomType;
            cbxRoomType.DisplayMemberPath = "RoomTypeName";
            cbxRoomType.SelectedValuePath = "RoomTypeId";
            cbxRoomType.SelectedIndex = 0;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCbxRoomType();
            LoadData();
        }



        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            var selectedRooms = dgvDisplay.ItemsSource as ObservableCollection<RoomInformation>;
            if (selectedRooms.IsNullOrEmpty()) { return; }

            List<RoomInformation> bookRooms = selectedRooms.ToList();
            bookRooms = bookRooms.Where(x => x.IsSelected).ToList();

            if (bookRooms.IsNullOrEmpty())
            {
                MessageBox.Show("Please choose at least 1 room to book !");
                return;
            }



            Checkout c = new Checkout(bookRooms) { customerId = this.customerId };

            c.ShowDialog();

            LoadData();

        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {

            var rooms = roomInformationService.GetRoomInformations();
            var booking = bookingDetailService.GetBookingDetails();

            DateOnly? from = dpkFrom.SelectedDate.HasValue ? DateOnly.FromDateTime(dpkFrom.SelectedDate.Value) : null;
            DateOnly? to = dpkTo.SelectedDate.HasValue ? DateOnly.FromDateTime(dpkTo.SelectedDate.Value) : null;

            int roomTypeId = int.Parse(cbxRoomType.SelectedValue.ToString());

            if (roomTypeId != 0)
            {
                rooms = rooms.Where(x => x.RoomTypeId == roomTypeId).ToList();
                booking = booking.Where(x => x.Room.RoomTypeId == roomTypeId).ToList();
            }

            if ((from == null && to != null) || (from != null && to == null))
            {
                MessageBox.Show("You must choose both From and To time.");
                return;
            }

            if (from != null && to != null)
            {
               
                var bookedRoomIds = booking
                    .Where(x => !(x.EndDate.CompareTo(from) < 0 || x.StartDate.CompareTo(to) > 0)) 
                    .Select(x => x.RoomId)
                    .Distinct()
                    .ToList();

               
                rooms = rooms.Where(x => !bookedRoomIds.Contains(x.RoomId)).ToList();


            }

            var roomsObservable = new ObservableCollection<RoomInformation>(rooms);
            dgvDisplay.ItemsSource = roomsObservable;

        }
    }
}
