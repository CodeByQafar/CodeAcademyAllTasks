using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Simulation6.Models;
using Simulation6.Utilities.Enums;
using Simulation6.ViewModels.Account;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            AppUser? user = await _userManager.Users.FirstOrDefaultAsync(p => p.Email == registerVM.Email);
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
            if (!await _userManager.Users.AnyAsync())
            {
                IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(registerVM);

                }
                if (!await _roleManager.Roles.AnyAsync(p => p.Name == UserRole.Admin.ToString()))
                    await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Admin.ToString()));

                await _userManager.AddToRoleAsync(newUser, UserRole.Admin.ToString());

            }
            else
            {
                IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(registerVM);

                }
                if ((!await _roleManager.Roles.AnyAsync(p => p.Name == UserRole.Memeber.ToString())))
                    await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Memeber.ToString()));

                await _userManager.AddToRoleAsync(newUser, UserRole.Memeber.ToString());
            }



       

            await _signInManager.PasswordSignInAsync(newUser, registerVM.Password, false, false);
            return RedirectToAction("index", "home");
        }
        [HttpPost]

        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser? user = _userManager.Users.FirstOrDefault(p => p.UserName == loginVM.UserNameOrEmail);
            if (user == null)
            {
                user = _userManager.Users.FirstOrDefault(p => p.Email == loginVM.UserNameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "UserName or Password is incorrect");
                    return View(loginVM);
                }
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }


        public async Task<IActionResult> CreateRole()
        {
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                if (!await _roleManager.RoleExistsAsync(role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName: role.ToString()));
                }
            }
            return RedirectToAction("index", "home");

        }
    }
}
