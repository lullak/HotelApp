using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HotelApp.Repository.Repos
{
    public class BookingRepo
    {
        private readonly HotelAppDbContext _context;

        public BookingRepo(HotelAppDbContext context)
        {
            _context = context;
        }

        // Get all bookings

        public List<Booking> GetAllBookings()
        {
            return _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Room)
                .Include(b => b.Invoice)
                .ToList();
        }

        // Add booking
        public void AddBooking(Booking booking)
        {
            // Check if room is already booked for the selected dates
            bool isRoomAvailable = !_context.Bookings
                .Any(b => b.RoomId == booking.RoomId &&
                          ((b.CheckInDate >= booking.CheckInDate && b.CheckInDate <= booking.CheckOutDate) ||
                           (b.CheckOutDate >= booking.CheckInDate && b.CheckOutDate <= booking.CheckOutDate)));
            if (isRoomAvailable)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Room is already booked for the selected dates.");
            }
        }

        // Update booking
        public void UpdateBooking(Booking updatedBooking)
        {
            var originalBooking = _context.Bookings.SingleOrDefault(b => b.BookingId == updatedBooking.BookingId);
            if (originalBooking != null)
            {
                _context.Entry(originalBooking).CurrentValues.SetValues(updatedBooking);
                _context.SaveChanges();
            }
        }

        // Delete booking
        public void DeleteBooking(int bookingId)
        {
            var booking = _context.Bookings.SingleOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

        // Get available rooms for a date range and number of people
        public List<Room> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate, int numberOfPeople)
        {
            var bookedRoomIds = _context.Bookings
                .Where(b => (b.CheckInDate >= checkInDate && b.CheckInDate <= checkOutDate) ||
                           (b.CheckOutDate >= checkInDate && b.CheckOutDate <= checkOutDate))
                .Select(b => b.RoomId)
                .ToList();

            return _context.Rooms
                .Where(r => !bookedRoomIds.Contains(r.RoomId) && r.Capacity >= numberOfPeople)
                .ToList();
        }
    }
}
