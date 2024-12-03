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
    /// Interaction logic for EditRoomType.xaml
    /// </summary>
    public partial class EditRoomType : Window
    {
        private RoomTypeService roomTypeService = new();
        public RoomType EditedRoomType { get; set; }
        public EditRoomType()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            RoomType type = new RoomType()
            {
                RoomTypeId = int.Parse(txtId.Text),
                RoomTypeName = txtName.Text,
                TypeDescription = txtDescription.Text,
                TypeNote = txtNote.Text
            };
            if (type.RoomTypeName.IsNullOrEmpty())
            {
                MessageBox.Show("Room Type Name can not be empty");
                return;
            }

            roomTypeService.UpdateRoomType(type);
            this.Close();

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtId.Text = EditedRoomType.RoomTypeId.ToString();
            txtName.Text = EditedRoomType.RoomTypeName;
            txtDescription.Text = EditedRoomType.TypeDescription;
            txtNote.Text = EditedRoomType.TypeNote;
        }
    }
}
