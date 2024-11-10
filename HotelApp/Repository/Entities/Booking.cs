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

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public int? InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }

        [DefaultValue(false)]
        public bool IsCancelled { get; set; } = false; 

        public void CancelBookingIfOverdue()
        {
            if (Invoice != null && Invoice.IsPaymentOverdue(BookingDate))
            {
                IsCancelled = true;
            }
        }

        public override string ToString()
        {
            DateTime dueDate = BookingDate.AddDays(10);

            string bookingInfo = $"{Customer.Name} \t Rum: {Room.RoomName} \t " +
                                 $"Betald: {(Invoice?.IsPaid == true ? "Ja" : "Nej")} \t " +
                                 $"Bokningsdatum: {BookingDate:d} \t " +
                                 $"Check-In: {CheckInDate:d} \t Check-Out: {CheckOutDate:d} \t Förfallodatum: {dueDate:d}";


            if (Invoice?.IsPaid == false && BookingDate.AddDays(10) < DateTime.Now)
            {
                bookingInfo += " \t (Annullerad)";
            }
            return bookingInfo;
        }
    }
}
