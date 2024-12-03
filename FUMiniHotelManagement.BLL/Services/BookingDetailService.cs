using FUMiniHotelManagement.DAL.Models;
using FUMiniHotelManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.BLL.Services
{

    public class BookingDetailService
    {
        private BookingDetailRepository _repo =new();

        private BookingDetailRepository _repoReservation =new();

        public List<BookingDetail> GetBookingDetails()
        {
            return _repo.GetAll();
        }

        public void AddBookingDetail(BookingDetail x)
        {
            _repo.Add(x);
        }

        public List<BookingDetail> GenerateReport(DateOnly startDate, DateOnly endDate)
        {

            
            List<BookingDetail> bookingDetails = _repo.GetAll().Where(x=> x.BookingReservation.BookingStatus == 2).ToList();

            var filteredDetails = bookingDetails
                .Where(b => b.StartDate >= startDate && b.EndDate <= endDate)
                .ToList();

            var sortedDetails = filteredDetails
                .OrderByDescending(b => b.ActualPrice)
                .ToList();

            return sortedDetails; 
        }
    }
}
