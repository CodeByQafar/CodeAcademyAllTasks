using AdminPanel.Areas.Admin.Controllers.Home;
using AdminPanel.Models;
using AdminPanel.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdminPanel.Controllers.Auth
{
    public class AuthController : Controller
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
 
        public IActionResult Login()
        {
            return View();
        }     
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            AppUser newUser = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
             
            };
           IdentityResult result =await _userManager.CreateAsync(newUser, model.Password);
            if(!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            return RedirectToAction(nameof(HomeController.Index),nameof(HomeController));
        }
    }
}
