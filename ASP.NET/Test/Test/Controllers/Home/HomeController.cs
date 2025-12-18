using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
