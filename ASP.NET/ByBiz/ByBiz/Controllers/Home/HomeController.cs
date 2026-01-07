using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
