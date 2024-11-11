using System.ComponentModel.DataAnnotations;

namespace HotelApp.Repository.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [StringLength(50)]
        public string RoomName { get; set; } 

        [Required]
        [StringLength(50)]
        public string RoomType { get; set; } 

        [Required]
        public bool HasExtraBed { get; set; }

        [Range(1, 2, ErrorMessage = "Antalet extra sängar måste vara mellan 1 and 2.")]
        public int? ExtraBedCount { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "Kapacitet måste vara mellan 1 and 4.")]
        public int Capacity { get; set; }

        public ICollection<Booking> Bookings { get; set; }


        public override string ToString()
        {
            return $"{RoomName} - Kapacitet: {Capacity}, Max antal extra sängar: {ExtraBedCount}";
        }
    }
}
