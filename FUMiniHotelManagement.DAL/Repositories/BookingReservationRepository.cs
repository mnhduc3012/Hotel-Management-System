using FUMiniHotelManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.DAL.Repositories
{
    public class BookingReservationRepository
    {

        private FuminiHotelManagementContext _context;


        public List<BookingReservation> GetAll()
        {
            _context = new();
            return _context.BookingReservations.Include(x=>x.Customer).ToList();
        }

        public int Add(BookingReservation x)
        {
            _context = new();
            _context.BookingReservations.Add(x);
            _context.SaveChanges();
            return x.BookingReservationId;
        }

        public void Update(BookingReservation x)
        {
            _context = new();
            _context.BookingReservations.Update(x);
            _context.SaveChanges();
            
        }

    }
}
