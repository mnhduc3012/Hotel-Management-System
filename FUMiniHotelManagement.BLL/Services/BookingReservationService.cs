using FUMiniHotelManagement.DAL.Models;
using FUMiniHotelManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.BLL.Services
{
    public class BookingReservationService
    {
        private BookingReservationRepository _repo = new();

        public List<BookingReservation> GetBookingReservations()
        {
            return _repo.GetAll();
        }

        public int AddBookingReservation(BookingReservation x)
        {
            return _repo.Add(x);
        }

        public void UpdateBookingReservation(BookingReservation x)
        {
            _repo.Update(x);
        }

    }
}
