using EDUHOME.DAL;
using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin,Moderator")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context;
        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.Where(x=>x.EmailConfirmed==true).ToList();
            List<UserVM> userVMs = new List<UserVM>();

            //userVMs.AddRange(users.Select(user=>new UserVM
            //{
            //    Id= user.Id,
            //    Name= user.Name,
            //    Surname= user.Surname,
            //    Email= user.Email,
            //    IsDeleted= user.IsDeleted,
            //    Role=(await _userManager.GetRolesAsync(user))[0]

            //}));

            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    UserName = user.UserName,
                    Email = user.Email,
                    IsDeleted = user.IsDeleted,
                    Role = (await _userManager.GetRolesAsync(user))[0]

                };
                userVMs.Add(userVM);
            }


            return View(userVMs);
        }
        public async Task<IActionResult> Activity(string id)
        {

            if (id == null) return View();
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null) return NotFound();
            if (appUser.IsDeleted)
            {
                appUser.IsDeleted = false;
            }
            else
            {
                appUser.IsDeleted = true;
            }
            await _userManager.UpdateAsync(appUser);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser appuser = await _userManager.FindByIdAsync(id);
            if (appuser == null) return NotFound();
            string role = (await _userManager.GetRolesAsync(appuser)).First();
            ViewBag.MyRole = role;
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            ViewBag.Courses = _context.Courses.Where(x=>x.AppUserId==null||x.AppUserId==id).Include(c => c.DetailCourse).ToList();
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string newRole, List<int?> courseId)
        {
            ViewBag.Courses = _context.Courses.Where(x => x.AppUserId == null|| x.AppUserId == id).Include(c => c.DetailCourse).ToList();
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            if (id == null) return NotFound();
            AppUser appuser = await _userManager.FindByIdAsync(id);
            if (appuser == null) return NotFound();
            string oldRole = (await _userManager.GetRolesAsync(appuser)).First();
            if (oldRole != newRole)
            {
                IdentityResult addresult = await _userManager.AddToRoleAsync(appuser, newRole);
                if (!addresult.Succeeded)
                {
                    ModelState.AddModelError("", "Some problem exist");

                    return View(roles);
                }
                IdentityResult removeresult = await _userManager.RemoveFromRoleAsync(appuser, oldRole);
                if (!removeresult.Succeeded)
                {
                    ModelState.AddModelError("", "Some problem exist");

                    return View(roles);
                }
                
                await _userManager.UpdateAsync(appuser);

            }
            if (newRole == "Moderator")
            {
                if (courseId != null)
                {
                    List<Course> oldCourses = await _context.Courses.Where(x => x.AppUserId == id).ToListAsync();
                    foreach (Course course in oldCourses)
                    {
                        appuser.courses.Remove(course);
                    }
                    await _context.SaveChangesAsync();
                    foreach (int cId in courseId)
                    {
                        Course course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == cId);
                        if (course == null)
                            return NotFound();
                        course.AppUserId = id;
                    }
                    await _context.SaveChangesAsync();

                }
            }
            else{
                List<Course> oldCourses = await _context.Courses.Where(x => x.AppUserId == id).ToListAsync();
                foreach (Course course in oldCourses)
                {
                    course.AppUserId = null;
                    await _context.SaveChangesAsync();

                }
            }
            return RedirectToAction(nameof(Index));

        }
        //public async Task CreateSubscriber()
        //{
        //    List<AppUser> appusers = await _userManager.Users.Where(u => u.IsSubscribed).ToListAsync();
        //    List<Subsciber> subscibers = new List<Subsciber>();
        //    foreach (AppUser user in appusers)
        //    {
        //        subscibers.Add(new Subsciber
        //        {
        //            IsSubscribed = user.IsSubscribed,
        //            Email = user.Email
        //        });

        //    }
        //    await _context.Subscibers.AddRangeAsync(subscibers);
        //    await _context.SaveChangesAsync();
            


        //}
    }
}
