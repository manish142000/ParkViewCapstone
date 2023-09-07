using Microsoft.AspNetCore.Mvc;
using ParkView.Models;



namespace ParkView.ViewComponents
{
    public class CouponMenu : ViewComponent
    {
        private readonly HotelDbContext hotelDbContext;

        public CouponMenu(HotelDbContext hotelDbContext)
        {
            this.hotelDbContext = hotelDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var Coupon_menu = hotelDbContext.discountCoupons.ToList();
            return View(Coupon_menu);
        }
    }
}