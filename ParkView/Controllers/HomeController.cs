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
            //return View(_hotelDbContext.roomCategories.ToArray());
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