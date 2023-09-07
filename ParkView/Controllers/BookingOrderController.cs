using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.Security.Claims;

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
            List<BookingCartItem> bookingCartItems = _bookingcart.GetBookingCartItems();

            DiscountCoupon coupon = _hotelDbContext.discountCoupons.ToList()[0];

            // remove earlier bookings with status false 
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var user = _hotelDbContext.Users.FirstOrDefault(x => x.Id == userId);

            IEnumerable<Booking> bookings = _hotelDbContext.bookings.Where(x => x.UserEmail == user.Email);

            //for( var item in bookings)
            //{
                
            //}

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

            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var user = _hotelDbContext.Users.FirstOrDefault(x => x.Id == userId);

            //booking with status false; 

            Booking item = new Booking
            {
                UserEmail = user.Email,
                CheckInDate = form.check_in,
                CheckOutDate = form.check_out,
                TotalCost = form.OrderTotal,
                Status = false
            };

            _hotelDbContext.bookings.Add(item);
            _hotelDbContext.SaveChanges();
            
            return RedirectToAction("InitiatePayment", "Payment");
        }
    }
}
