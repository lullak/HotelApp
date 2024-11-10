using System.ComponentModel.DataAnnotations;

namespace HotelApp.Repository.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{Email,-30}\t{PhoneNumber}";
        }
    }
}
