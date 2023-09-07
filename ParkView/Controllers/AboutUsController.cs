using Microsoft.AspNetCore.Mvc;

namespace ParkView.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
