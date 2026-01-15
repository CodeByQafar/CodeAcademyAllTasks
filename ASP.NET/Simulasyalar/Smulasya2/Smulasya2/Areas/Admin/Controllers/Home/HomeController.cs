using Microsoft.AspNetCore.Mvc;

namespace Smulasya2.Areas.Admin.Controllers.Home
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
