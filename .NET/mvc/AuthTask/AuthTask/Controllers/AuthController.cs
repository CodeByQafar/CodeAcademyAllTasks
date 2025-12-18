using Microsoft.AspNetCore.Mvc;

namespace AuthTask.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return RedirectToAction("About", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string email, string password)
        {
            return RedirectToAction("Login");
        }
    }
}
