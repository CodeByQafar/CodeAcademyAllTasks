using Microsoft.AspNetCore.Mvc;

namespace ProniaConsoleApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blog()
        {
            return View();
        }
    }
}
