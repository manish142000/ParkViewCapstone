using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using ParkView.ViewModels;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace ParkView.Controllers
{
    public class BookingCartController : Controller
    {
        private readonly BookingCart _bookingCart;
        private readonly HotelDbContext _hotelDbContext;
        private readonly IRoomCategory _categories;

        public BookingCartController( BookingCart bookingCart, HotelDbContext hotelDbContext, IRoomCategory categories )
        {
            _bookingCart = bookingCart;
            _hotelDbContext = hotelDbContext;
            _categories = categories;
        }

        public IActionResult Index(string CouponName)
        {
            _bookingCart.BookingCartItems = _bookingCart.GetBookingCartItems();

            DiscountCoupon discountCoupon = _hotelDbContext.discountCoupons.FirstOrDefault( x => x.CouponName == CouponName );

            BookingCartViewModel BookingCartviewModel = new BookingCartViewModel();

            if (discountCoupon == null)
            {
                BookingCartviewModel = new BookingCartViewModel
                { 
                    BookingCart = _bookingCart,
                    total = _bookingCart.GetBookingCartTotal()
                };
            }
            else
            {
                BookingCartviewModel = new BookingCartViewModel
                {
                    BookingCart = _bookingCart,

                    total = _bookingCart.ApplyDiscount(discountCoupon),

                    CouponName = CouponName,
                    CouponDiscount = discountCoupon.DiscountAmount,

                    PriceAfterDiscount = _bookingCart.ApplyDiscount(discountCoupon)
                };
            }

            return View(BookingCartviewModel);
        }

        public RedirectToActionResult RemoveFromBookingCart(int bookingCartItemId)
        {
            _bookingCart.RemoveFromBookingCart(bookingCartItemId);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearBookingCart()
        {
            _bookingCart.ClearCart();
            return RedirectToAction("Index");
        }

        public RedirectToActionResult AddToBookingCart(int RoomCategoryId)
        {
            RoomCategory category = _categories.GetCategorybyId(RoomCategoryId);

            _bookingCart.AddToCart(category);

            return RedirectToAction("Index");
        }
    }
}
