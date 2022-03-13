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

namespace EDUHOME.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public readonly UserManager<AppUser> _userManager;
        public CoursesController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course = _context.Courses.Include(c => c.DetailCourse).Include(x=>x.Comments).ThenInclude(x=>x.AppUser).FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }
        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment(ComentCreatedVM comentCreatedVM)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Detail", "Courses", new { Id = comentCreatedVM.CourseId });
            }

            Course course = _context.Courses.Include(x=>x.Comments).FirstOrDefault(x => x.Id == comentCreatedVM.CourseId);
            if (course == null) return NotFound();
            
            if (_context.Comments.Any(x=>x.CourseId==comentCreatedVM.CourseId&& x.AppUserId== user.Id))
            {
                return RedirectToAction("Detai", "Courses", new { Id = comentCreatedVM.CourseId });
            }
            Comment comment = new Comment()
            {
                AppUserId = user.Id,
                Rate = comentCreatedVM.Rate,
                CourseId = comentCreatedVM.CourseId,
                Messgae = comentCreatedVM.Messgae,
                CreatedAt=DateTime.UtcNow.AddHours(4)
            };
            course.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "Courses", new { Id = comentCreatedVM.CourseId });
        }
        public IActionResult Search(string search)
        {
            List<Course> courses = _context.Courses.Where(x=>x.IsDeleted==false&&x.Name.ToLower().Trim().Contains(search.ToLower().Trim())).ToList();
            return PartialView("_CoursePartial",courses);
        }
    }
    
}
