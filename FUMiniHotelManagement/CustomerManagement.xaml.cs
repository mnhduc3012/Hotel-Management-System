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
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Page
    {
        private CustomerService customerService = new();
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text;

            dgvDisplay.ItemsSource = customerService.SearchByName(keyword);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer c = new AddCustomer();
            c.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Customer? selected = dgvDisplay.SelectedItem as Customer;

            if (selected == null)
            {
                MessageBox.Show("Please choose a customer to edit !");
                return;
            }
            EditCustomer c = new EditCustomer { EditedCustomer = selected };

            c.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Customer? selected = dgvDisplay.SelectedItem as Customer;

            if (selected == null)
            {
                MessageBox.Show("Please choose a customer to delete !");
                return;
            }

            MessageBoxResult ans = MessageBox.Show("Do you really want to delete?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (ans == MessageBoxResult.No) { return; }

            customerService.DeleteCustomer(selected);
            LoadData();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            var customers = customerService.GetCustomers();
            dgvDisplay.ItemsSource = null;
            dgvDisplay.ItemsSource = customers;

        }
    }
}
