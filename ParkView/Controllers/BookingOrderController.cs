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

            User user = _hotelDbContext.Users.FirstOrDefault(x => x.Id == userId) as User;

            IEnumerable<Booking> bookings = _hotelDbContext.bookings.Where(x => x.UserEmail == user.Email);

            TemporaryData data = _hotelDbContext.temporaryData.ToList().Last();


            double total = _bookingcart.ApplyDiscount(coupon);

            CheckOut form = new CheckOut
             {
                Email = user.Email,
                FullName = user.FirstName + " " + user.LastName,
                bookingCartItems = bookingCartItems,
                OrderTotal = total,
                Phone = user.PhoneNumber,
                check_in = data.checkin,
                check_out = data.checkout
             };

            return View(form);
        }

        [HttpPost]
        public RedirectToActionResult Index(CheckOut form) {

            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var user = _hotelDbContext.Users.FirstOrDefault(x => x.Id == userId);

            var data = _hotelDbContext.temporaryData.ToList().Last();

            //booking with status false; 

            Booking item = new Booking
            {
                UserEmail = user.Email,
                CheckInDate = data.checkin,
                CheckOutDate = data.checkout,
                TotalCost = form.OrderTotal,
                Status = false
            };
            _hotelDbContext.bookings.Add(item);
            _hotelDbContext.SaveChanges();

            //List of rooms with a particular booking Cart Id
            
            return RedirectToAction("InitiatePayment", "Payment");
        }
            
            
        }
    
}
