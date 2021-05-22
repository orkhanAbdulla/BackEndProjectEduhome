﻿using EDUHOME.DAL;
using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
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
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> userVMs = new List<UserVM>();
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
            ViewBag.Courses = _context.Courses.Include(c => c.DetailCourse).ToList();
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string newRole, List<int?> courseId)
        {
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            if (id == null) return NotFound();
            AppUser appuser = await _userManager.FindByIdAsync(id);
            if (appuser == null) return NotFound();
            string oldRole = (await _userManager.GetRolesAsync(appuser)).First();
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
            if (courseId != null)
            {
                foreach (int cId in courseId)
                {
                    Course course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == cId);
                    if (course == null)
                        return NotFound();
                    course.AppUserId = id;
                    await _context.SaveChangesAsync();
                }

            }
            return RedirectToAction(nameof(Index));

        }
    }
}