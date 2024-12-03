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
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Window
    {
        private RoomTypeService roomTypeService = new();
        private RoomInformationService roomInformationService = new();
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var room = GetRoomForm();

            if (room == null)
            {
                MessageBox.Show("Invalid input !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            roomInformationService.AddRoomInformation(room);
            this.Close();

        }

        private RoomInformation? GetRoomForm()
        {

            try
            {
                string roomNumber = txtRoomNumber.Text;
                string roomDescription = txtRoomDescription.Text;
                int maxCapicity = int.Parse(txtRoomMaxCapacity.Text);
                byte status = cbxRoomStatus.SelectedItem.ToString().Equals("Active") ? (byte)1 : (byte)2;
                decimal PricePerDay = decimal.Parse(txtRoomPricePerDay.Text);
                int RoomTypeId = int.Parse(cbxRoomType.SelectedValue.ToString());

                return new RoomInformation
                {

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var roomStatus = new string[] { "Active", "Deleted" };
            cbxRoomStatus.ItemsSource = roomStatus;
            cbxRoomStatus.SelectedIndex = 0;

            var roomTypes = roomTypeService.GetRoomTypes();
            cbxRoomType.ItemsSource = roomTypes;
            cbxRoomType.DisplayMemberPath = "RoomTypeName";
            cbxRoomType.SelectedValuePath = "RoomTypeId";
            cbxRoomType.SelectedIndex = 0;
        }
    }
}
