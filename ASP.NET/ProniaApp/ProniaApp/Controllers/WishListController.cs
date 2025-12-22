using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
