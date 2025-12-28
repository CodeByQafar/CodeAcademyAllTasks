using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers.Shop
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
