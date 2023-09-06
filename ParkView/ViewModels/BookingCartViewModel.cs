using ParkView.Models;

namespace ParkView.ViewModels
{
    public class BookingCartViewModel
    {
        public BookingCart BookingCart { get; set; }

        public double total { get; set; }

        public string CouponName { get; set; }

        public int CouponDiscount { get; set; }

        public double PriceAfterDiscount { get; set; }
    }
}
