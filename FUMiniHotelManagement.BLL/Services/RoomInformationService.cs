using FUMiniHotelManagement.DAL.Models;
using FUMiniHotelManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMiniHotelManagement.BLL.Services
{
    public class RoomInformationService
    {
        private RoomInformationRepository _roomInformationRepository = new();

        public List<RoomInformation> GetRoomInformations()
        {
            return _roomInformationRepository.GetAll();
        }

        public void AddRoomInformation(RoomInformation x)
        {
            _roomInformationRepository.Add(x);
        }

        public void UpdateRoomInformation(RoomInformation x)
        {
            _roomInformationRepository.Update(x);
        }

        public void DeleteRoomInformation(RoomInformation x)
        {
            _roomInformationRepository.Delete(x);
        }

        public List<RoomInformation> SearchByPrice(decimal? min, decimal? max) { 
        
            var rooms = _roomInformationRepository.GetAll();

            if (min != null)
            {
                rooms = rooms.Where(x => x.RoomPricePerDay >= min).ToList();
            }
            if (max != null)
            {
                rooms = rooms.Where(x => x.RoomPricePerDay <= max).ToList();
            }
            return rooms;

        }
    }
}
