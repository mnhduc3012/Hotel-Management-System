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
    /// Interaction logic for RoomTypeManagement.xaml
    /// </summary>
    public partial class RoomTypeManagement : Page
    {
        private RoomTypeService roomTypeService = new();
        public RoomTypeManagement()
        {
            InitializeComponent();
        }

        private void Load()
        {
            var data = roomTypeService.GetRoomTypes();

            dgvDisplay.ItemsSource = data;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text;
            dgvDisplay.ItemsSource = roomTypeService.SearchByName(keyword);

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            AddRoomType addRoomType = new AddRoomType();
            addRoomType.ShowDialog();
            Load();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            RoomType? selected = dgvDisplay.SelectedItem as RoomType;


            if (selected == null)
            {
                MessageBox.Show("Please choose room type to edit");
                return;
            }

            EditRoomType editRoomType = new EditRoomType()
            {
                EditedRoomType = selected
            };
            editRoomType.ShowDialog();
            Load();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            RoomType? selected = dgvDisplay.SelectedItem as RoomType;


            if(selected == null)
            {
                MessageBox.Show("Please choose room type to delete");
                return;
            }

          MessageBoxResult result =  MessageBox.Show("Are you sure you want to delete?","Confirmation",MessageBoxButton.YesNo, MessageBoxImage.Question);


            if (result == MessageBoxResult.Yes)
            {
                roomTypeService.RemoveRoomType(selected);
                Load();
            }
        }
    }
}
