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

        public List<Booking> GetAllBookings()
        {
            return _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Room)
                .Include(b => b.Invoice)
                .OrderByDescending(b => b.BookingDate)
                .ToList();
        }

        public void CancelOverdueBookings()
        {
            var overdueBookings = _context.Bookings
                                    .Include(b => b.Invoice)
                                    .AsEnumerable()
                                    .Where(b => !b.IsCancelled &&
                                    b.Invoice != null &&
                                    !b.Invoice.IsPaid &&
                                    (DateTime.Now - b.BookingDate).TotalDays > 10)
                                    .ToList();

            foreach (var booking in overdueBookings)
            {
                booking.IsCancelled = true;
            }
            _context.SaveChanges();
        }


        public Booking CreateBooking(Customer customer, Room room, DateTime checkInDate, DateTime checkOutDate, decimal amount)
        {

            var newBooking = new Booking
            {
                CustomerId = customer.CustomerId,
                RoomId = room.RoomId,
                BookingDate = DateTime.Now,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                IsCancelled = false
            };

            var newInvoice = new Invoice
            {
                Amount = amount,
                DateIssued = DateTime.Now,
                IsPaid = false
            };

            newBooking.Invoice = newInvoice;

            _context.Bookings.Add(newBooking);
            _context.Invoices.Add(newInvoice);
            _context.SaveChanges();

            return newBooking;
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = _context.Bookings
                .Include(b => b.Invoice)
                .FirstOrDefault(b => b.BookingId == bookingId);

            if (booking != null)
            {
                if (booking.Invoice != null)
                {
                    _context.Invoices.Remove(booking.Invoice);
                }

                _context.Bookings.Remove(booking);

                _context.SaveChanges();
            }
        }

        public void UpdateBooking(int bookingId, int newCustomerId, int newRoomId, DateTime newCheckInDate, DateTime newCheckOutDate, decimal newAmount, bool isPaid)
        {
            var booking = _context.Bookings
                .Include(b => b.Invoice)
                .FirstOrDefault(b => b.BookingId == bookingId);

            if (booking != null)
            {
                if (booking.CustomerId != newCustomerId)
                    booking.CustomerId = newCustomerId;

                if (booking.RoomId != newRoomId)
                    booking.RoomId = newRoomId;

                booking.CheckInDate = newCheckInDate;
                booking.CheckOutDate = newCheckOutDate;

                if (booking.Invoice != null)
                {
                    booking.Invoice.Amount = newAmount;
                    booking.Invoice.IsPaid = isPaid;
                }
                else
                {
                    booking.Invoice = new Invoice
                    {
                        Amount = newAmount,
                        DateIssued = DateTime.Now,
                        IsPaid = isPaid,
                    };
                }

                _context.SaveChanges();
            }
        }
    }
}
