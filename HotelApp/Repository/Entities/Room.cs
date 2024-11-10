using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ValidateExtraBeds()
        {
            if (HasExtraBed && (ExtraBedCount == null || ExtraBedCount < 1 || ExtraBedCount > 2))
            {
                throw new InvalidOperationException("Extra sängar måste vara mellan 1 och 2 if HasExtraBeds is true.");
            }
            else if (!HasExtraBed && ExtraBedCount != null)
            {
                throw new InvalidOperationException("ExtraBedCount måste vara null om Has extra beds är false.");
            }
        }

        public override string ToString()
        {
            return $"{RoomName} - Kapacitet: {Capacity}, Max antal extra sängar: {ExtraBedCount}";
        }
    }
}
