using FUMiniHotelManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.DAL.Repositories
{
    public class BookingDetailRepository
    {
        private FuminiHotelManagementContext _context;
        public List<BookingDetail> GetAll()
        {
            _context = new FuminiHotelManagementContext();
            return _context.BookingDetails.Include(x => x.Room).Include(x=>x.BookingReservation).ToList();
        }

        public void Add(BookingDetail x)
        {
            _context = new FuminiHotelManagementContext();
            _context.BookingDetails.Add(x);
            _context.SaveChanges();
        }
    }
}
