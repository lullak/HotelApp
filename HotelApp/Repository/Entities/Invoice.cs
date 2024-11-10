using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Repository.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime DateIssued { get; set; }

        [Required]
        public bool IsPaid { get; set; } = false;

        public Booking Booking { get; set; }

        public bool IsPaymentOverdue(DateTime bookingDate)
        {
            return !IsPaid && (DateTime.Now - bookingDate).TotalDays > 10;
        }
    }
}
