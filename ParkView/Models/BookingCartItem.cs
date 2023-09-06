using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class BookingCartItem
    {
        public int BookingCartItemId { get; set; }

        public string BookingCartId { get; set; }

        [ForeignKey("RoomCategory")]
        public int RoomCategoryId { get; set; }
        public RoomCategory RoomCategory { get; set; }

        public int quantity { get; set; }
    }
}
