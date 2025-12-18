using Microsoft.AspNetCore.Mvc;

namespace AuthTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
    }
}
