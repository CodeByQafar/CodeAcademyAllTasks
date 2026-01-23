using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Data;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Utilities.Enums;
using WebApplication1.ViewModels.Account;

namespace WebApplication1.Controllers.Account
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

        public IActionResult Logout()
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
            AppUser? user = await _userManager.Users.FirstOrDefaultAsync(p => p.UserName == registerVM.UserName);
            if (user != null)
            {
                ModelState.AddModelError("UserName", errorMessage: "user name used on other account");
                return View(registerVM);

            }
            user = await _userManager.Users.FirstOrDefaultAsync(p => p.Email == registerVM.Email);
            if (user != null)
            {
                ModelState.AddModelError("Email", errorMessage: "Email name used on other account");

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
                if (!await _roleManager.RoleExistsAsync(UserRole.Admin.ToString()))
                    await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Admin.ToString()));


            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, errorMessage: error.Description);

                    }
                    return View(registerVM);

                }
                await _userManager.AddToRoleAsync(newUser, UserRole.Admin.ToString());


            }
            else
            {

                if (!await _roleManager.RoleExistsAsync(UserRole.Member.ToString()))
                    await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Member.ToString()));

                IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, errorMessage: error.Description);

                    }
                    return View(registerVM);

                }

                await _userManager.AddToRoleAsync(newUser, UserRole.Member.ToString());

            }



            await _signInManager.PasswordSignInAsync(newUser, registerVM.Password, false, false);
            return RedirectToAction("Index", "home");
        }
        [HttpPost]

        public async Task<IActionResult> Login(LoginVM loginVM)
        {


            if (!ModelState.IsValid)
            {
                return View(loginVM);

            }
            AppUser? user = await _userManager.Users.FirstOrDefaultAsync(p => p.UserName == loginVM.UserNameOrEmail);
            if (user == null)
            {
                user = await _userManager.Users.FirstOrDefaultAsync(p => p.Email == loginVM.UserNameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError("", errorMessage: "username or password is incorrect");

                    return View(loginVM);

                }


            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", errorMessage: "username or password is incorrect");

                return View(loginVM);


            }
            return RedirectToAction("Index", "home");

        }
        public async Task<IActionResult> CreateRole(LoginVM loginVM)
        {
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                if (!await _roleManager.RoleExistsAsync(roleName: role.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName: role.ToString()));
                }
            }


            //await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Admin.ToString()));
            //await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.moderator.ToString()));
            //await _roleManager.CreateAsync(new IdentityRole(roleName: UserRole.Member.ToString()));

            return RedirectToAction("Index", "home");
        }

    }
}
