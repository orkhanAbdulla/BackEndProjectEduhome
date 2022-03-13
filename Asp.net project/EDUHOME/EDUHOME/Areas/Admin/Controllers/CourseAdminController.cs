using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
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
    //[Authorize(Roles = "Admin")]
    public class CourseAdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public readonly UserManager<AppUser> _userManager;
        public CourseAdminController(AppDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            //Where(x => x.AppUserId ==)
            ////ViewBag.IsDeleted = IsDeleted;
            List<Course> courses = _context.Courses.OrderByDescending(x => x.Id).Include(c => c.DetailCourse).Include(x=>x.Comments).ToList();
            return View(courses);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Course courses = _context.Courses.Where(c => c.IsDeleted == false).Include(c => c.DetailCourse).FirstOrDefault(c=>c.Id==id);
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
            if (course.Photo==null)
            {
                ModelState.AddModelError("Photo", "Please select image");
                return View();
            }
            else
            {
                if (!course.Photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("Photo", "Please select image Type");
                    return View();
                }
                if (!course.Photo.IsValidSize(300))
                {
                    ModelState.AddModelError("Photo", "Please select image Size less than kb");
                    return View();
                }
            }
           
            string path = Path.Combine("img", "course");
            course.ImageUrl = await course.Photo.SavaFileAsync(_env.WebRootPath, path);


            course.DetailCourse.Course= course;
            course.DetailCourse.CourseId = course.Id;
            await _context.AddRangeAsync(course, course.DetailCourse);

            await _context.SaveChangesAsync();
            string Massage = "https://localhost:44398/Courses/Detail/" + course.Id.ToString();
            List<Subsciber> subscibers = _context.Subscibers.ToList();
            foreach (Subsciber sub in subscibers)
            {
               await Helper.SendMessageAsync("New Course", Massage, sub.Email);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            if (!course.IsDeleted)
            {
                course.IsDeleted = true;

            }
            else
            {
                course.IsDeleted = false;

            }
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
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
          

            if (!ModelState.IsValid) return View(CourseServer);
            if (course.Photo!=null)
            {
                if (!course.Photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("Photo", "Please select image Type");
                    return View(CourseServer);
                }
                if (!course.Photo.IsValidSize(300))
                {
                    ModelState.AddModelError("Photo", "Please select image Size less than kb");
                    return View(CourseServer);
                }
                string path = Path.Combine("img", "course");
                Helper.DeleteFile(_env.WebRootPath, path, CourseServer.ImageUrl);
                path = Path.Combine("img", "course");
                CourseServer.ImageUrl = await course.Photo.SavaFileAsync(_env.WebRootPath, path);
            }
            CourseServer.Name = course.Name;
            CourseServer.Description = course.Description;
            CourseServer.DetailCourse.AboutCourse = course.DetailCourse.AboutCourse;
            CourseServer.DetailCourse.HowToApply = course.DetailCourse.HowToApply;
            CourseServer.DetailCourse.Certification = course.DetailCourse.Certification;
            CourseServer.DetailCourse.Starts = course.DetailCourse.Starts;
            CourseServer.DetailCourse.Duration = course.DetailCourse.Duration;
            CourseServer.DetailCourse.ClassDuration = course.DetailCourse.ClassDuration;
            CourseServer.DetailCourse.SkillLevel = course.DetailCourse.SkillLevel;
            CourseServer.DetailCourse.Language = course.DetailCourse.Language;
            CourseServer.DetailCourse.Students = course.DetailCourse.Students;
            CourseServer.DetailCourse.Assesments = course.DetailCourse.Assesments;
            CourseServer.DetailCourse.Price = course.DetailCourse.Price;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Comments(int Id)
        {
            List<Comment> commnets = _context.Comments.Include(x => x.AppUser).Where(x => x.CourseId == Id).ToList();
            return View(commnets);
        }
        public IActionResult CommentAccept(int id)
        {
            Comment comment = _context.Comments.Find(id);
            if (comment == null) return NotFound();
            comment.Status = true;
            Course course = _context.Courses.Include(x => x.Comments).FirstOrDefault(x => x.Id == comment.CourseId);
            if (course.Comments.Where(x => x.Status == true).Count() == 0)
            {
                course.Rate = 0;
            }
            else
            {
                course.Rate = (int)Math.Round(course.Comments.Where(x => x.Status == true).Average(x => x.Rate));
            }
            _context.SaveChanges();
            return RedirectToAction("Comments", new { Id = comment.CourseId });
        }
        public IActionResult CommentReject(int id)
        {
            Comment comment = _context.Comments.Find(id);
            if (comment == null) return NotFound();
            comment.Status = false;
            _context.SaveChanges();
            Course course = _context.Courses.Include(x => x.Comments).FirstOrDefault(x => x.Id == comment.CourseId);
            if (course.Comments.Where(x => x.Status == true).Count() == 0)
            {
                course.Rate = 0;
            }
            else
            {
                course.Rate = (int)Math.Round(course.Comments.Where(x => x.Status == true).Average(x => x.Rate));
            }
            _context.SaveChanges();
            return RedirectToAction("Comments", new { Id = comment.CourseId });
        }



    }
}
