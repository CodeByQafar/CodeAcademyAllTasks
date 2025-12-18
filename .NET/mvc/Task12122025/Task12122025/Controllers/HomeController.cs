using Microsoft.AspNetCore.Mvc;

namespace Task12122025.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
