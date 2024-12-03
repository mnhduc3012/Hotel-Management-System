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
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Page
    {
        private RoomInformationService roomInformationService = new();
        public RoomManagement()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            AddRoom a = new AddRoom();
            a.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            RoomInformation? selected = dgvDisplay.SelectedItem as RoomInformation;

            if (selected == null)
            {
                MessageBox.Show("Please choose a room to edit !");
                return;
            }

            EditRoom edit = new EditRoom
            {
                EditedRoom = selected
            };
            edit.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            RoomInformation? selected = dgvDisplay.SelectedItem as RoomInformation;
            if (selected == null)
            {
                MessageBox.Show("Please choose a room to delete !");
                return;
            }

            MessageBoxResult ans = MessageBox.Show("Do you really want to delete?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (ans == MessageBoxResult.No) { return; }


            roomInformationService.DeleteRoomInformation(selected);
            LoadData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            decimal? min;
            decimal? max;

            decimal tmpMin;
            decimal tmpMax;

            bool parseMin = decimal.TryParse(txtMin.Text, out tmpMin);
            bool parseMax = decimal.TryParse(txtMax.Text, out tmpMax);


            if ((!parseMin && txtMin.Text.Length > 0) || (!parseMax && txtMax.Text.Length > 0))
            {
                MessageBox.Show("Please enter a valid decimal number for the price range!");
                return;
            }
            min = parseMin ? tmpMin : null;
            max = parseMax ? tmpMax : null;



            dgvDisplay.ItemsSource = roomInformationService.SearchByPrice(min, max);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            var rooms = roomInformationService.GetRoomInformations();
            dgvDisplay.ItemsSource = null;
            dgvDisplay.ItemsSource = rooms;

        }
    }
}
