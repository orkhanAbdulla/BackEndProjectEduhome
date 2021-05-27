using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Helpers;
using EDUHOME.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin")]
    public class TeacherAdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherAdminController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).ToList();
            return View(teachers);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _context.Teachers.FirstOrDefaultAsync(c => c.Id == id);
            if (teacher == null) return NotFound();
            if (!teacher.IsDeleted)
            {
                teacher.IsDeleted = true;

            }
            else
            {
                teacher.IsDeleted = false;

            }
            _context.UpdateRange(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (!ModelState.IsValid) return View();

            if (!teacher.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
                return View();
            }
            if (!teacher.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
                return View();
            }
            string path = Path.Combine("img", "teacher");
            teacher.ImageUrl = await teacher.Photo.SavaFileAsync(_env.WebRootPath, path);

            teacher.TeacherDetail.Teacher = teacher;
            teacher.TeacherDetail.TeacherId = teacher.Id;

            await _context.AddRangeAsync(teacher, teacher.TeacherDetail);
            string Massage = "https://localhost:44398/Teacher/Detail/" + teacher.Id.ToString();
            List<Subsciber> subscibers = _context.Subscibers.ToList();
            foreach (Subsciber sub in subscibers)
            {
                await Helper.SendMessageAsync("New Teacher", Massage, sub.Email);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Teacher teacher)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            Teacher teacherDb = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).FirstOrDefault(t => t.Id == id);
            if (teacherDb == null) return NotFound();
            if (!teacher.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
                return View(teacherDb);
            }
            if (!teacher.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
                return View(teacherDb);
            }
            string path = Path.Combine("img", "course");
            Helper.DeleteFile(_env.WebRootPath, path, teacherDb.ImageUrl);
            path = Path.Combine("img", "teacher");
            teacherDb.ImageUrl = await teacher.Photo.SavaFileAsync(_env.WebRootPath, path);
            teacherDb.Fullname = teacher.Fullname;
            teacherDb.Position = teacher.Position;
            teacherDb.TeacherDetail.AboutMe = teacher.TeacherDetail.AboutMe;
            teacherDb.TeacherDetail.Degree = teacher.TeacherDetail.Degree;
            teacherDb.TeacherDetail.Experience = teacher.TeacherDetail.Experience;
            teacherDb.TeacherDetail.Hobbies = teacher.TeacherDetail.Hobbies;
            teacherDb.TeacherDetail.Faculty = teacher.TeacherDetail.Faculty;
            teacherDb.TeacherDetail.MailMe = teacher.TeacherDetail.MailMe;
            teacherDb.TeacherDetail.Call = teacher.TeacherDetail.Call;
            teacherDb.TeacherDetail.Skype = teacher.TeacherDetail.Skype;
            teacherDb.TeacherDetail.Language = teacher.TeacherDetail.Language;
            teacherDb.TeacherDetail.Design = teacher.TeacherDetail.Design;
            teacherDb.TeacherDetail.TeamLeader = teacher.TeacherDetail.TeamLeader;
            teacherDb.TeacherDetail.Innovation = teacher.TeacherDetail.Innovation;
            teacherDb.TeacherDetail.Development = teacher.TeacherDetail.Development;
            teacherDb.TeacherDetail.Communication = teacher.TeacherDetail.Communication;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
