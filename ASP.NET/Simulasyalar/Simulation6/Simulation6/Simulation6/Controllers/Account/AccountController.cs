using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Simulation6.Models;
using Simulation6.ViewModels.Account;

namespace Simulation6.Controllers.Account
{
    public class AccountController : Controller
    {

        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;
        public readonly RoleManager<IdentityRole> _roleManager;


        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
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
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser? user =await _userManager.Users.FirstOrDefaultAsync(p=>p.Email==registerVM.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", "Email adres used on other account");
                return View(registerVM);

            }
            user = await _userManager.Users.FirstOrDefaultAsync(p => p.UserName == registerVM.UserName);
            if (user != null)
            {
                ModelState.AddModelError("UserName", "UserName used on other account");
                return View(registerVM);

            }
            AppUser newUser = new AppUser
            {
                FullName = registerVM.FullName,
                UserName = registerVM.UserName,
                Email = registerVM.Email

            };
            IdentityResult result =await _userManager.CreateAsync(newUser,registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(registerVM);

            }
            await _signInManager.PasswordSignInAsync(newUser, registerVM.Password, false, false);
            return RedirectToAction("index","home");
        }
        [HttpPost]

        public IActionResult Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            return View(loginVM);
        }
    }
}
