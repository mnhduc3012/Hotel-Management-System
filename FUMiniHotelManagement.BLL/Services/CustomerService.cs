using FUMiniHotelManagement.DAL.Models;
using FUMiniHotelManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.BLL.Services
{
    public class CustomerService
    {
        private CustomerRepository _repo = new();

        public List<Customer> GetCustomers()
        {
            return _repo.GetAll();
        }

        public void AddCustomer(Customer x)
        {
            _repo.Add(x);
        }

        public void UpdateCustomer(Customer x)
        {
            _repo.Update(x);
        }

        public void DeleteCustomer(Customer x)
        {
            _repo.Delete(x);
        }

        public Customer? Login(string email, string password)
        {
            var x = _repo.GetAll().Where(x => x.EmailAddress.Equals(email) && x.Password.Equals(password)).FirstOrDefault();
            return x;
        }

        public List<Customer> SearchByName(string? keyword)
        {
            var result = _repo.GetAll();
            if (keyword != null)
            {
                result = result.Where(x => x.CustomerFullName.ToLower().Contains(keyword.ToLower())).ToList();
            }
            return result;
        }
    }
}
