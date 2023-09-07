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
        private readonly IRoomCategory _roomCategory;
        private readonly IRoom _room;
        private readonly IBookingRoom _bookingroom;

        public HomeController(ILogger<HomeController> logger, HotelDbContext context
            , IHotel hotel, IRoom room, IBookingRoom bookingroom, IRoomCategory roomCategory)
        {
            _logger = logger;
            _context = context;
            _hotel = hotel;
            _room = room;
            _bookingroom = bookingroom;
            _roomCategory = roomCategory;
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
            TemporaryData data = new TemporaryData
            {
                checkin = form.check_in,
                checkout = form.check_out
            };

            IEnumerable<Hotel> Hotels = _hotel.GetHotelsByLocation(form.destination);


            List<Room> rooms = new List<Room>();
            foreach( var hotel in Hotels )
            {
                data.hotel = hotel.HotelId;
                rooms.AddRange( _room.GetRoomsByHotelId(hotel.HotelId) );
            }

            _context.temporaryData.Add(data);

            _context.SaveChanges();

            List<BookingRoom> bookedRooms = _bookingroom.BookedRooms();


            if( bookedRooms.Any() )
            {
                foreach (var bookedroom in bookedRooms)
                {


                    Booking booking = _context.bookings.FirstOrDefault(x => x.BookingId == bookedroom.BookingId);

                    Room room = _context.rooms.FirstOrDefault(x => x.RoomId == bookedroom.RoomId);

                    if( booking != null)
                    {
                        if ( (booking.Status) && (booking.CheckOutDate >= form.check_in &&  booking.CheckInDate <= form.check_in ) || (booking.CheckInDate <= form.check_out && booking.CheckOutDate >= form.check_out))
                        {
                            rooms.Remove(room);
                        }
                    }
                }
            }
            List<RoomCategory> roomTypes = _roomCategory.GetAllCategories().ToList();
            string[] imgUrls = new string[roomTypes.Count];
            string[] roomTypeNames = new string[roomTypes.Count()];
            for (int i = 0; i < roomTypes.Count; i++)
            {
                roomTypeNames[i] = roomTypes[i].CategoryName;
                imgUrls[i] = roomTypes[i].ImageUrl;
            }

            int[] avlRooms = new int[roomTypes.Count()];
            foreach (var avlRoom in rooms)
            {
                avlRooms[avlRoom.RoomCategoryId - 1]++;
            }
            IndexViewModel obj = new IndexViewModel
            {
                rooms = rooms,
                roomTypeNames = roomTypeNames,
                imageUrls = imgUrls,
                availableRooms = avlRooms
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