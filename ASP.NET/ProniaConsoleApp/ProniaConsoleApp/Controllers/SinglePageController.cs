using Microsoft.AspNetCore.Mvc;

namespace ProniaConsoleApp.Controllers
{
    public class SinglePageController : Controller
    {
        public IActionResult singlepage()
        {
            return View();
        }
    }
}
