using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class SingleProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
