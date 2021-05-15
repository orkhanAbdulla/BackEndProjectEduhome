using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Helpers;
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
            List<Course> courses = _context.Courses.Include(c => c.DetailCourse).ToList();
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
        public async Task<IActionResult> Create(Course course)
        {
            if (!ModelState.IsValid) return View();
            //bool isExist = _context.Courses.Any(c => c.Name.ToLower().Trim() == courseVM.Course.Name.ToLower().Trim());
            //if (isExist)
            //{
            //    ModelState.AddModelError("Name", "Bu adda kategoriya movcuddur");
            //    return View();
            //}
            if (!course.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
            }
            if (!course.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
            }
            string path = Path.Combine("img", "course");
            course.ImageUrl = await course.Photo.SavaFileAsync(_env.WebRootPath, path);
            course.DetailCourse.Course= course;
            course.DetailCourse.CourseId = course.Id;

            await _context.AddRangeAsync(course,course.DetailCourse);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Activity(int? id)
        {
            if (id == null) return NotFound();
            Course course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
            course.IsDeleted = course.IsDeleted == true ? false : true;
            _context.Courses.Update(course);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
         
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Course course = _context.Courses.Include(c => c.DetailCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();

            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id ,Course course)
        {
            if (id == null) return NotFound();
            Course CourseServer = _context.Courses.Include(c => c.DetailCourse).FirstOrDefault(c=>c.Id== id);
            if (CourseServer == null) return NotFound();
            string path = Path.Combine("img", "course");
            Helper.DeleteFile(_env.WebRootPath, path, CourseServer.ImageUrl);

            if (!ModelState.IsValid) return View();
            if (!course.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
            }
            if (!course.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
            }
            path = Path.Combine("img", "course");
            CourseServer.ImageUrl = await course.Photo.SavaFileAsync(_env.WebRootPath, path);

            course = CourseServer;
            course.DetailCourse = CourseServer.DetailCourse;
            _context.UpdateRange(course, course.DetailCourse);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
