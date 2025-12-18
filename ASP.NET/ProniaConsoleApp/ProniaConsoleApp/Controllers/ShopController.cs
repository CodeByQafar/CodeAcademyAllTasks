using Microsoft.AspNetCore.Mvc;

namespace ProniaConsoleApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
