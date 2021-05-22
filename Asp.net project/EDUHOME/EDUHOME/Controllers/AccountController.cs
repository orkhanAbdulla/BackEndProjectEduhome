using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);
                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "Вы не подтвердили свой email");
                        return View(loginVM);
                    }
                }
                var signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, true);
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }

            }
            
            return View(loginVM);
        }
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register( RegisterVM registerVM)
        {

            if (ModelState.IsValid)
            {
                AppUser newuser = new AppUser
                {
                    Name = registerVM.Name,
                    Surname = registerVM.Surname,
                    UserName = registerVM.UserName,
                    Email = registerVM.Email,
                     
                };

                IdentityResult identityResult = await _userManager.CreateAsync(newuser, registerVM.Password);
                await _userManager.AddToRoleAsync(newuser, Roles.Member.ToString());

                if (identityResult.Succeeded)
                {
                    // генерация токена для пользователя
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(newuser);
                    var callbackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new { userId = newuser.Id, code = code },
                        protocol: HttpContext.Request.Scheme);
                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync(registerVM.Email, "Confirm your account",
                        $"Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>link</a>");

                    return Content("Для завершения регистрации проверьте электронную почту и перейдите по ссылке, указанной в письме");
                }
            }
            //else
            //{
            //    foreach (IdentityError error in identityResult.Errors)
            //    {
            //        ModelState.AddModelError("", error.Description);
            //    }
            //}
            return View(registerVM);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return View("Error");
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
