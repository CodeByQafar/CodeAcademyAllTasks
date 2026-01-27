using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticket4.Models;
using ticket4.ViewModels;

namespace ticket4.Controllers.Account
{
    public class AccountController : Controller
    {

        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;
        public readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager) { 
        _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            AppUser? user =await _userManager.Users.FirstOrDefaultAsync(p=>p.Email==vm.Email);
            if (user!=null) {
                user = await _userManager.Users.FirstOrDefaultAsync(p => p.UserName == vm.UserName);
                if (user != null)
                {
                
                }
                }
                return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM vm)
        {
            return View();
        }
    }
}
