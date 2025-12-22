using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class error404 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
