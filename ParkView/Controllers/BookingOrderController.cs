using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkView.Models;

namespace ParkView.Controllers
{
    [Authorize]
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
            Console.WriteLine("Coming Here");
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
        public RedirectToActionResult Index( CheckOut form ) {

            return RedirectToAction("InitiatePayment", "Payment");
        }
    }
}
