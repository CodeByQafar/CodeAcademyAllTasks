using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
