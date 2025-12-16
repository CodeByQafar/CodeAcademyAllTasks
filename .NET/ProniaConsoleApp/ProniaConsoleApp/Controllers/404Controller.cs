using Microsoft.AspNetCore.Mvc;

namespace ProniaConsoleApp.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult _404()
        {
            return View();
        }
    }
}
