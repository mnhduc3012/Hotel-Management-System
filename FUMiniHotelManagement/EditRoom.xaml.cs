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
    /// Interaction logic for EditRoom.xaml
    /// </summary>
    public partial class EditRoom : Window
    {
        public RoomInformation EditedRoom { get; set; }
        private RoomTypeService roomTypeService =new();
        private RoomInformationService roomInformationService = new();
        public EditRoom()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var room = GetRoomForm();

            if (room == null)
            {
                MessageBox.Show("Invalid input !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //var x = roomInformationService.GetRoomInformations().FirstOrDefault(x=>x.RoomId == room.RoomId);

            //if (x == null)
            //{
            //    MessageBox.Show("ID is not existed !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
            //else
            //{
                
                
            //}

            roomInformationService.UpdateRoomInformation(room);
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var roomStatus = new string[] { "Active", "Deleted" };
            cbxRoomStatus.ItemsSource = roomStatus;

            var roomTypes = roomTypeService.GetRoomTypes();
            cbxRoomType.ItemsSource = roomTypes;
            cbxRoomType.DisplayMemberPath = "RoomTypeName";
            cbxRoomType.SelectedValuePath = "RoomTypeId";
            
            txtRoomID.Text = EditedRoom.RoomId.ToString();
            txtRoomNumber.Text = EditedRoom.RoomNumber;
            txtRoomDescription.Text = EditedRoom.RoomDetailDescription;
            txtRoomMaxCapacity.Text = EditedRoom.RoomMaxCapacity.ToString();
            cbxRoomStatus.SelectedItem = EditedRoom.RoomStatus == 1 ? "Active" : "Deleted";
            txtRoomPricePerDay.Text = EditedRoom.RoomPricePerDay.ToString();
            cbxRoomType.SelectedValue = EditedRoom.RoomTypeId;
        }
        private RoomInformation? GetRoomForm()
        {

            try
            {
                int roomId = int.Parse(txtRoomID.Text);
                string roomNumber = txtRoomNumber.Text;
                string roomDescription = txtRoomDescription.Text;
                int maxCapicity = int.Parse(txtRoomMaxCapacity.Text);
                byte status = cbxRoomStatus.SelectedItem.ToString().Equals("Active") ? (byte)1 : (byte)2;
                decimal PricePerDay = decimal.Parse(txtRoomPricePerDay.Text);
                int RoomTypeId = int.Parse(cbxRoomType.SelectedValue.ToString());

                return new RoomInformation
                {
                    RoomId = roomId,
                    RoomNumber = roomNumber,
                    RoomDetailDescription = roomDescription,
                    RoomMaxCapacity = maxCapicity,
                    RoomPricePerDay = PricePerDay,
                    RoomStatus = status,
                    RoomTypeId = RoomTypeId
                };
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
