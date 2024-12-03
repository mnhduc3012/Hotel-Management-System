using FUMiniHotelManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.DAL.Repositories
{
    public class CustomerRepository
    {
        private FuminiHotelManagementContext _context;
        public List<Customer> GetAll()
        {
            _context = new();
            return _context.Customers.ToList();
        }

        public void Add(Customer x)
        {
            _context = new();
            _context.Customers.Add(x);
            _context.SaveChanges();
        }
    
        public void Update(Customer x)
        {
            _context = new();
            _context.Customers.Update(x);
            _context.SaveChanges();
        }

        public void Delete(Customer x)
        {
            _context = new();
            _context.Customers.Remove(x);
            _context.SaveChanges();
        }
    }
}
