using Microsoft.AspNetCore.Mvc;

namespace FitnessTemplate.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
