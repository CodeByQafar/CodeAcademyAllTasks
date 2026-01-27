using Microsoft.AspNetCore.Mvc;

namespace ticket4.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
