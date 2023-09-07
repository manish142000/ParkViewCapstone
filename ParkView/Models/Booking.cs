using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public string UserEmail { get; set; }

        public DateTime  CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public double TotalCost { get; set; } 

        public Boolean Status { get; set; }
    }
}
