using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class BookingCartItem
    {
        public int BookingCartItemId { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }

        public Room Room { get; set; }

        public string BookingCartId { get; set; }
    }
}
