using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HotelApp.Repository.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        // Foreign Key for Customer (1 to many relationship)
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        // Foreign Key for Room (1 to many relationship)
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        // Foreign Key for Invoice (1 to 1 relationship)
        public int InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        // Flag to indicate if the booking is cancelled
        [DefaultValue(false)] // This is optional in the C# model
        public bool IsCancelled { get; set; } = false; // Default value set in the class

        // Method to cancel booking if payment is overdue
        public void CancelBookingIfOverdue()
        {
            if (Invoice != null && Invoice.IsPaymentOverdue(BookingDate))
            {
                IsCancelled = true;
            }
        }
    }
}
