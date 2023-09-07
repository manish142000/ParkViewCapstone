using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using Razorpay.Api;
using System.Security.Claims;

namespace ParkView.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly BookingCart _bookingCart;
        private readonly HotelDbContext _hotelDbContext;

        public PaymentController( BookingCart bookingCart, HotelDbContext hotelDbContext )
        {
            _bookingCart = bookingCart;
            _hotelDbContext = hotelDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InitiatePayment()
        {
            string key = "rzp_test_JQErjnHoBPqTHQ";
            string secret = "G2LGzFSf7qhfw5xLBj5dtEXP";

            DiscountCoupon discountCoupon = _hotelDbContext.discountCoupons.FirstOrDefault(x => x.CouponId == 1);

            Random _random = new Random();
            string TransactionId = _random.Next(0, 10000).ToString();

            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", Convert.ToDecimal(_bookingCart.ApplyDiscount(discountCoupon)) * 100); // this amount should be same as transaction amount
            input.Add("currency", "INR");
            input.Add("receipt", TransactionId);

            RazorpayClient client = new RazorpayClient(key, secret);

            Razorpay.Api.Order order = client.Order.Create(input);


            ViewBag.orderid = order["id"].ToString();

            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            var user = _hotelDbContext.Users.FirstOrDefault( x => x.Id == userId );


            UserModel u_ser = new UserModel
            {
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Name = user.UserName
            };

            return View("Payment", u_ser);
        }

        public IActionResult payment( string razorpay_payment_id, string razorpay_order_id, string razorpay_signature)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();

            attributes.Add("razorpay_payment_id", razorpay_payment_id);
            attributes.Add("razorpay_order_id", razorpay_order_id);
            attributes.Add("razorpay_signature", razorpay_signature);

            Utils.verifyPaymentSignature(attributes);

            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var user = _hotelDbContext.Users.FirstOrDefault(x => x.Id == userId);

            // logic to save in the booking table
            // 
            Booking item = _hotelDbContext.bookings.FirstOrDefault( x => x.UserEmail == user.Email );

            item.Status = true;

            _hotelDbContext.SaveChanges();

            // sending Order Id and transaction id to frontend

            UserModel obj = new UserModel();

            obj.OrderId = razorpay_order_id;
            obj.TransactionId = razorpay_payment_id;

            return View("PaymentSuccess", obj);
        }
    }
}
