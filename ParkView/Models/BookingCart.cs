﻿using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ParkView.Models
{
    public class BookingCart
    {
        public string BookingCartId { get; set; }

        public List<BookingCartItem> BookingCartItems { get; set; }       


        public double total { get; set; }

        private readonly HotelDbContext _hotelDbContext;


        public BookingCart( HotelDbContext hotelDbContext)
        {
            _hotelDbContext = hotelDbContext;
        }


        public static BookingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;

            var context = services.GetService<HotelDbContext>();

            string cartid = session.GetString("CartId");
            if (cartid == null)
            {
                cartid = Guid.NewGuid().ToString();
                session.SetString("CartId", cartid);
            }

            return new BookingCart(context) { BookingCartId = cartid };
        }

        public void AddToCart(RoomCategory roomCategory)
        {

            var BookingCartItem = _hotelDbContext.bookingCartItems.SingleOrDefault(
                x => x.BookingCartId == BookingCartId && x.RoomCategoryId == roomCategory.RoomCategoryId  );

            TemporaryData data = _hotelDbContext.temporaryData.ToArray().Last();

            Hotel hotel = _hotelDbContext.hotels.FirstOrDefault(x => x.HotelId == data.hotel);

            if( BookingCartItem == null)
            {
                BookingCartItem = new BookingCartItem
                {
                    RoomCategory = roomCategory,
                    BookingCartId = BookingCartId,
                    quantity = 1,
                    CheckInDate = data.checkin,
                    CheckOutDate = data.checkout,
                    HotelName = hotel.Name,
                    Location = hotel.Location
                };

                _hotelDbContext.bookingCartItems.Add(BookingCartItem);
            }
            else
            {
                BookingCartItem.quantity = BookingCartItem.quantity + 1;
            }

            _hotelDbContext.SaveChanges();
        }

        public List<BookingCartItem> GetBookingCartItems()
        {
            return BookingCartItems ??= _hotelDbContext.bookingCartItems.Where(
                x => x.BookingCartId == BookingCartId
                ).Include(x => x.RoomCategory).ToList();
        }

        public double GetBookingCartTotal()
        {
            double amount = _hotelDbContext.bookingCartItems.Where(
                x => x.BookingCartId == BookingCartId
                ).Select(c => c.RoomCategory.DailyRate * c.quantity).Sum();

            amount = amount + amount * 0.18;

            return amount;
        }

        public double ApplyDiscount( DiscountCoupon discountCoupon)
        {
            double amount = _hotelDbContext.bookingCartItems.Where(
                x => x.BookingCartId == BookingCartId
                ).Select(c => c.RoomCategory.DailyRate * c.quantity).Sum();

            double discountAmount = amount * discountCoupon.DiscountAmount * 0.01;

            // GST 18%
            amount = amount + amount * 0.18; 

            amount = amount - discountAmount;

            return amount;
        }

        public void RemoveFromBookingCart(int id)
        {

            var BookingCartItem = _hotelDbContext.bookingCartItems.SingleOrDefault( s => s.BookingCartItemId == id && s.BookingCartId == BookingCartId );

            if(BookingCartItem != null && BookingCartItem.quantity > 0 )
            {
                BookingCartItem.quantity--;
                if( BookingCartItem.quantity == 0)
                {
                    _hotelDbContext.bookingCartItems.Remove(BookingCartItem);
                }
                _hotelDbContext.SaveChanges();
            }
        }

        public void ClearCart()
        {
            _hotelDbContext.bookingCartItems.RemoveRange(_hotelDbContext.bookingCartItems);

            _hotelDbContext.SaveChanges();
        }

    }
}
