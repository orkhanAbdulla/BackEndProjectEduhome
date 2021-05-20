using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Username or Password is wrong");
                return View();
            }
            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "User is deactivated");
                return View();
            }
            var signInResult=await _signInManager.PasswordSignInAsync(user, loginVM.Password,loginVM.RememberMe,true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please try few minutes later");
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is wrong");
                return View();
            }
            if ((await _userManager.GetRolesAsync(user))[0]==Roles.Admin.ToString())
            {
                return RedirectToAction("Index", "Dashboard",new { area="Admin" });
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register( RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser newuser = new AppUser
            {
                Name=registerVM.Name,
                Surname=registerVM.Surname,
                UserName=registerVM.UserName,
                Email=registerVM.Email
            };
            IdentityResult identityResult=await _userManager.CreateAsync(newuser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newuser,Roles.Member.ToString());
            await _signInManager.SignInAsync(newuser, true);
            return RedirectToAction("Index", "Home");

           
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");

        }
       
        #region Create Roles
        //public async Task CreateRoles()
        //{
        //    foreach (var role in Enum.GetValues(typeof(Roles)))
        //    {
        //        if (!(await _roleManager.RoleExistsAsync(role.ToString())))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }

        //    }
        //}
        #endregion





    }
}
