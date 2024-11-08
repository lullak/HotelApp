using HotelApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Repos
{
    public class RoomRepo
    {
        private readonly HotelAppDbContext _context;

        public RoomRepo(HotelAppDbContext context)
        {
            _context = context;
        }
        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }

        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room updatedRoom)
        {
            var originalRoom = _context.Rooms.SingleOrDefault(r => r.RoomId == updatedRoom.RoomId);
            if (originalRoom != null)
            {
                _context.Entry(originalRoom).CurrentValues.SetValues(updatedRoom);
                _context.SaveChanges();
            }
        }
        public void DeleteRoom(int roomId)
        {
            var room = _context.Rooms.SingleOrDefault(r => r.RoomId == roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}
