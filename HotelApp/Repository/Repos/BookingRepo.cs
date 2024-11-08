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

        public List<Booking> Search(string condition)
        {
            return _context.Bookings.Where(b => b.Customer.Name.Contains(condition)).ToList();
        }
        // CREATE: Add a new booking
        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        // READ: Get a booking by ID
        public Booking? GetBookingById(int bookingId)
        {
            return _context.Bookings
                .Include(b => b.Customer)   // Optional: Include related data
                .Include(b => b.Room)       // Optional: Include related data
                .Include(b => b.Invoice)    // Optional: Include related data
                .FirstOrDefault(b => b.BookingId == bookingId);
        }

        // READ: Get all bookings (optionally filtered by a condition)
        public List<Booking> GetAllBookings()
        {
            return _context.Bookings
                .Include(b => b.Customer)  // Optional: Include related data
                .Include(b => b.Room)      // Optional: Include related data
                .Include(b => b.Invoice)   // Optional: Include related data
                .ToList();  
        }

        // UPDATE: Update an existing booking
        public void UpdateBooking(Booking booking)
        {
            using (HotelAppDbContext db = _context)  // Use _context instead of creating a new instance
            {
                // Fetch the original booking record to be updated
                Booking original = db.Bookings.SingleOrDefault(b => b.BookingId == booking.BookingId);

                if (original != null)
                {
                    // Update the original booking with the new values
                    db.Entry(original).CurrentValues.SetValues(booking);

                    // Save the changes to the database
                    db.SaveChanges();
                }
            }
        }

        // DELETE: Delete a booking by ID
        public bool DeleteBooking(int bookingId)
        {
            var bookingToDelete = _context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (bookingToDelete == null)
            {
                return false; // Booking not found
            }

            _context.Bookings.Remove(bookingToDelete);
            _context.SaveChanges();

            return true; // Booking deleted successfully
        }
    }
}
