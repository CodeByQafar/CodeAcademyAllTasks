using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
