using Microsoft.AspNetCore.Mvc;

namespace ProniaConsoleApp.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult wishlist()
        {
            return View();
        }
    }
}
