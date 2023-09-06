using Microsoft.AspNetCore.Mvc;
using ParkView.Models;

namespace ParkView.Controllers
{
    public class BookingOrderController : Controller
    {
        private readonly BookingCart _bookingcart;
        private readonly HotelDbContext _hotelDbContext;

        public BookingOrderController(BookingCart bookingCart, HotelDbContext hotelDbContext)
        {
            _bookingcart = bookingCart;
            _hotelDbContext = hotelDbContext;
        }
        public IActionResult Index()
        {
             List<BookingCartItem> bookingCartItems = _bookingcart.GetBookingCartItems();

             DiscountCoupon coupon = _hotelDbContext.discountCoupons.ToList()[0];

             double total = _bookingcart.ApplyDiscount(coupon);

            CheckOut form = new CheckOut
             {
                bookingCartItems = bookingCartItems,
                OrderTotal = total
             };

            return View(form);
        }

        [HttpPost]
        public IActionResult Index( CheckOut form ) {

            return View();
        }
    }
}
