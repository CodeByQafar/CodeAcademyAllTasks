using FitnessTemplate.Models;
using FitnessTemplate.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTemplate.Controllers.Account
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

            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser? user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", "this user is email is used");
                return View(registerVM);

            }
            user = await _userManager.FindByNameAsync(registerVM.UserName);

            if (user != null)
            {
                ModelState.AddModelError("UserName", "this username is used");
                return View(registerVM);
            }
            AppUser appUser = new AppUser
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email,
                FullName = registerVM.FullName
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    Console.WriteLine(error.Description);
                }
                return View(registerVM);
            }
            await _signInManager.SignInAsync(appUser, false);
            return RedirectToAction("Index", "Home");

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser? user = await _userManager.FindByEmailAsync(loginVM.EmailOrUserName);
            if (user == null)
            {
                user = await _userManager.FindByNameAsync(loginVM.EmailOrUserName);
            }
            if (user == null)
            {
                ModelState.AddModelError("", "this user is not found");
                return View(loginVM);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, false);
            if (result.Succeeded)
            {

                return RedirectToAction("index", "home");
            }

            return View(loginVM);
        }
        public async Task<IActionResult> Logout(LoginVM loginVM) {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");

        }
    }
}
