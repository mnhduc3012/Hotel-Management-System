using FUMiniHotelManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.DAL.Repositories
{
    public class RoomInformationRepository
    {
        private FuminiHotelManagementContext _context;
        public List<RoomInformation> GetAll()
        {
            _context = new();
            return _context.RoomInformations.Include(x => x.RoomType).ToList();
        }

        public void Add(RoomInformation x)
        {
            _context = new();
            _context.RoomInformations.Add(x);
            _context.SaveChanges();
        }

        public void Update(RoomInformation x)
        {
            _context = new();
            _context.RoomInformations.Update(x);
            _context.SaveChanges();
        }

        public void Delete(RoomInformation x)
        {
            _context = new();
            _context.RoomInformations.Remove(x);
            _context.SaveChanges();
        }


    }
}
