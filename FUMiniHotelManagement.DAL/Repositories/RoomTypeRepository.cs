using FUMiniHotelManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.DAL.Repositories
{

    public class RoomTypeRepository
    {
        private FuminiHotelManagementContext _context;
        public List<RoomType> GetAll()
        {
            _context = new();
            return _context.RoomTypes.ToList();
        }

        public void Add(RoomType x)
        {
            _context = new();
            _context.RoomTypes.Add(x);
            _context.SaveChanges();
        }

        public void Update(RoomType x)
        {
            _context = new();
            _context.RoomTypes.Update(x);
            _context.SaveChanges();
        }

        public void Remove(RoomType x)
        {
            _context = new();
            _context.RoomTypes.Remove(x);
            _context.SaveChanges();
        }



    }
}
