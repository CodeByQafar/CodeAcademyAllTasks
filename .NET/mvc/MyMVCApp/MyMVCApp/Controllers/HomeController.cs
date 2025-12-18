using Microsoft.AspNetCore.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Generic()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
    }
}
