using FUMiniHotelManagement.DAL.Models;
using FUMiniHotelManagement.DAL.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.BLL.Services
{
    public class RoomTypeService
    {
        private RoomTypeRepository _repo = new();


        public List<RoomType> GetRoomTypes()
        {
            return _repo.GetAll();
        }

        public List<RoomType> SearchByName(string keyword)
        {
            var res = _repo.GetAll();

            if (!keyword.IsNullOrEmpty())
            {
                res = res.Where(x=>x.RoomTypeName.ToLower().Contains(keyword.ToLower())).ToList();
            }

            return res;

        }

        public void AddRoomType(RoomType x)
        {
            _repo.Add(x);
        }

        public void UpdateRoomType(RoomType x)
        {
            _repo.Update(x);
        }

        public void RemoveRoomType(RoomType x)
        {
            _repo.Remove(x);
        }




    }
}
