using EDUHOME.DAL;
using EDUHOME.Helpers;
using EDUHOME.Migrations;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDUHOME.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext context,UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
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
                        ModelState.AddModelError("", "Please confirim your email");
                        return View(loginVM);
                    }
                    Microsoft.AspNetCore.Identity.SignInResult signInResult =
                     await _signInManager.PasswordSignInAsync(user, loginVM.Password, true, true);
                    if (signInResult.IsLockedOut)
                    {
                        ModelState.AddModelError("", "Please,try few minutes later");
                        return View(loginVM);
                    }

                    if (!signInResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Username or password wrong!!!");
                        return View(loginVM);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Username or password wrong!!!");
                    return View();
                }
               
              
            }
            return View(loginVM);

        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
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
              

                if (identityResult.Succeeded)
                {
                    // Generate Token for user

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(newuser);
                    var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { userName = newuser.UserName,code}, Request.Scheme);
                    var mailto = newuser.Email;
                    var messageBody = $"<p>Emaili təsdiqləmək üçün <a href=\"{confirmationLink}\"> buraya daxil </a>  olun</p>" +
                        $"</br><p>Qeydiyatı yalnız bir dəfə təsdiqləyə bilərsiz</p>";
                    var messageSubject = "Email Təsdiqləmə";
                    await Helper.SendMessageAsync(messageSubject,messageBody, newuser.Email);
                    await _userManager.AddToRoleAsync(newuser, Roles.Admin.ToString());

                    return RedirectToAction("VerifyEmail","Account");
                }
                else
                {
                    foreach (IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            
            return View(registerVM);
        }
        public IActionResult VerifyEmail()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userName, string code)
        {
            if (userName == null || code == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                TempData["Response"] = "Email has been confirmed";
                return RedirectToAction("Login", "Account");
            }
            else
                return NotFound();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Subscribe(string email)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (email == null) return Content("Please write down your email your subscribing");
            if (!Regex.IsMatch(email, pattern)) return Content("Email is not valid");
            else
            {
                List<Subsciber> subscibersDb = _context.Subscibers.ToList();
                Subsciber subsciber = new Subsciber { Email = email };
                foreach (var item in subscibersDb)
                {
                    if (item.Email == email)
                    {
                        return Content("You are already subscribed");
                    }
                }
                await _context.Subscibers.AddAsync(subsciber);
                await _context.SaveChangesAsync();
                return Content("You have been Succesfully Subscribed");
            }
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
