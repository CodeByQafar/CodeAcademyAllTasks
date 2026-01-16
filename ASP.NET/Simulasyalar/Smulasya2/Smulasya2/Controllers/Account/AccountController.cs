using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Smulasya2.Models;
using Smulasya2.ViewvModels.Account;

namespace Smulasya2.Controllers.Account
{
    public class AccountController : Controller
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View( registerVM);
            }
            AppUser? user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", "this Email used on other account");
            }
            user = await _userManager.FindByNameAsync(registerVM.UserName);
            if (user != null)
            {
                ModelState.AddModelError("UserName", "this UserName used on other account");
            }
            AppUser newUser = new AppUser
            {
                FullName = registerVM.FullName,
                UserName=registerVM.UserName,
                Email=registerVM.Email,
                
            };
           IdentityResult result=await _userManager.CreateAsync(newUser,registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            await _signInManager.SignInAsync(newUser, false);

            return RedirectToAction("index","home");
        }
        public IActionResult Login(LoginVM loginVM)
        {
            return View();
        }
        public async Task<IActionResult> Logout( )
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }
    }
}
