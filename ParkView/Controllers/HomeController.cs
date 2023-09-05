using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.Diagnostics;
using MvcContrib.Filters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ParkView.ViewModels;

namespace ParkView.Controllers
{
    [PassParametersDuringRedirect]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HotelDbContext _context;
        private readonly IHotel _hotel;
        private readonly IRoom _room;
        private readonly IBookingRoom _bookingroom;

        public HomeController(ILogger<HomeController> logger, HotelDbContext context
            , IHotel hotel, IRoom room, IBookingRoom bookingroom)
        {
            _logger = logger;
            _context = context;
            _hotel = hotel;
            _room = room;
            _bookingroom = bookingroom;
        }

        public IActionResult Index()
        {

            IndexViewModel obj = new IndexViewModel
            {
                rooms = new List<Room>()
            };
            
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel form)
        {
            IEnumerable<Hotel> Hotels = _hotel.GetHotelsByLocation(form.destination);


            List<Room> rooms = new List<Room>();
            foreach( var hotel in Hotels )
            {
                rooms.AddRange( _room.GetRoomsByHotelId(hotel.HotelId) );
            }

            List<BookingRoom> bookedRooms = _bookingroom.BookedRooms();


            if( bookedRooms.Any() )
            {
                foreach (var bookedroom in bookedRooms)
                {
                    Booking booking = _context.bookings.FirstOrDefault(x => x.BookingId == bookedroom.BookingId);

                    Room room = _context.rooms.FirstOrDefault(x => x.RoomId == bookedroom.RoomId);

                    if( booking != null)
                    {
                        if ((booking.CheckInDate > form.check_in && booking.CheckOutDate < form.check_out) || (booking.CheckInDate > form.check_in && booking.CheckOutDate < form.check_out))
                        {
                            rooms.Remove(room);
                        }
                    }
                }
            }

            IndexViewModel obj = new IndexViewModel
            {
                rooms = rooms
            };

            return View(obj);

        }

        public IActionResult Rooms()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}