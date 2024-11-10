using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelApp.Repository
{
    public class HotelAppDbContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = ConfigurationManager.ConnectionStrings["HotelDekstopDB"].ConnectionString;
            //HotelDekstopDB och för laptopen HotelLaptopDB

            optionsBuilder.UseSqlServer(connString);
        }
    }
}
