using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Repository.Repos
{
    public class CustomerRepo
    {
        private readonly HotelAppDbContext _context;

        public CustomerRepo(HotelAppDbContext context)
        {
            _context = context;
        }

        public bool HasBookings(int customerId)
        {
            var bookings = _context.Bookings.Where(b => b.CustomerId == customerId).ToList();
            return bookings.Any();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers
                .AsNoTracking()
                .ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            var originalCustomer = _context.Customers.SingleOrDefault(c => c.CustomerId == updatedCustomer.CustomerId);
            if (originalCustomer != null)
            {
                _context.Entry(originalCustomer).CurrentValues.SetValues(updatedCustomer);
                _context.SaveChanges();
            }
        }


        public bool DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Include(c => c.Bookings).SingleOrDefault(c => c.CustomerId == customerId);
            if (customer != null && customer.Bookings.Count == 0)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
