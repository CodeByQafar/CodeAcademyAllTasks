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

        public IActionResult Login( )
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser? user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", "this Email used on other account");
                return View(registerVM);
            }
            user = await _userManager.FindByNameAsync(registerVM.UserName);
            if (user != null)
            {
                ModelState.AddModelError("UserName", "this UserName used on other account");
                return View(registerVM);

            }
            AppUser newUser = new AppUser
            {
                FullName = registerVM.FullName,
                UserName = registerVM.UserName,
                Email = registerVM.Email,

            };
            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    Console.WriteLine(error.Description);
                }
                return View(registerVM);

            }
            await _signInManager.SignInAsync(newUser, false);

            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser? user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
            if (user == null)
            {
               
                user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError("UserNameOrEmail", "user not found");
                    return View(loginVM);
                }
            }
            var result =await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, false);
            if (result.Succeeded)
            {

                return RedirectToAction("index", "home");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View(loginVM);

            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }
    }
}
