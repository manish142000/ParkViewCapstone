using Microsoft.AspNetCore.Mvc;

namespace ParkView.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
