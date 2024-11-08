using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Repository.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }  // Primary key

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime DateIssued { get; set; }

        // Tracks if the invoice has been paid
        [Required]
        public bool IsPaid { get; set; } = false;

        public Booking Booking { get; set; }

        // Method to check if payment is overdue (10 days after booking date)
        public bool IsPaymentOverdue(DateTime bookingDate)
        {
            return !IsPaid && (DateTime.Now - bookingDate).TotalDays > 10;
        }
    }
}
