using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkView.Models;

namespace ParkView.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }
    }
}
