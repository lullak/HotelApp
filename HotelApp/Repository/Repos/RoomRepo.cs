using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Repository.Repos
{
    public class RoomRepo
    {
        private readonly HotelAppDbContext _context;

        public RoomRepo(HotelAppDbContext context)
        {
            _context = context;
        }

        public List<Room> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate, int capacity)
        {
            return _context.Rooms
                .Include(r => r.Bookings)
                .Where(room =>
                    room.Capacity >= capacity &&
                    room.Bookings.All(b => b.IsCancelled ||
                                          b.CheckOutDate <= checkInDate ||
                                          b.CheckInDate >= checkOutDate))
                .ToList();
        }

        public bool IsRoomAvailable(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var isRoomBooked = _context.Bookings
                .Where(b => b.RoomId == roomId &&
                            ((b.CheckInDate >= checkInDate && b.CheckInDate < checkOutDate) ||
                             (b.CheckOutDate > checkInDate && b.CheckOutDate <= checkOutDate)))
                .Any();

            return !isRoomBooked;
        }
        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
    }
}
