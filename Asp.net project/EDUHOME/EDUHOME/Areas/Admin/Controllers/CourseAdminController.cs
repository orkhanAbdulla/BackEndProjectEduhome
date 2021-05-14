using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseAdminController : Controller
    {
        private readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;
        public CourseAdminController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailCourse).ToList();
            return View(courses);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            List<Course> courses = _context.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailCourse).ToList();
            if (courses == null) return NotFound();
            return View(courses);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseVM courseVM)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Courses.Any(c => c.Name.ToLower().Trim() == courseVM.Course.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda kategoriya movcuddur");
                return View();
            }
            if (!courseVM.Course.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
            }
            if (!courseVM.Course.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
            }
            string path = Path.Combine("img", "course");
            courseVM.Course.ImageUrl = await courseVM.Course.Photo.SavaFileAsync(_env.WebRootPath, path);

            courseVM.DetailCourse.CourseId = courseVM.Course.Id;
            await _context.Courses.AddAsync(courseVM.Course);
            await _context.DetailCourses.AddAsync(courseVM.DetailCourse);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
