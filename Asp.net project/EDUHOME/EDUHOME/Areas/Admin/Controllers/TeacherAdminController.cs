using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Helpers;
using EDUHOME.Models;
using EDUHOME.ViewModels;
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
    //[Authorize(Roles = "Admin")]
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
        public async Task<IActionResult> Create(TeacherVM teacherVM)
        {

            teacherVM.Teacher.Skills= new List<Skill>();

            if (!ModelState.IsValid) return View();

            if (!teacherVM.Teacher.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
                return View();
            }
            if (!teacherVM.Teacher.Photo.IsValidSize(900))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
                return View();
            }
            string path = Path.Combine("img", "teacher");

            teacherVM.Teacher.ImageUrl = await teacherVM.Teacher.Photo.SavaFileAsync(_env.WebRootPath, path);
            teacherVM.TeacherDetail.Teacher = teacherVM.Teacher;
            teacherVM.TeacherDetail.TeacherId = teacherVM.Teacher.Id;

            for (int i = 0; i < teacherVM.SkillName.Count; i++)
            {
                teacherVM.Teacher.Skills.Add(new Skill { Name = teacherVM.SkillName[i], Percentage = teacherVM.SkillPercentage[i], TeacherId= teacherVM.Teacher.Id});
            }
            await _context.AddRangeAsync(teacherVM.Teacher, teacherVM.TeacherDetail);
            //string Massage = "https://localhost:44398/Teacher/Detail/" + teacherVM.Teacher.Id.ToString();
            //List<Subsciber> subscibers = _context.Subscibers.ToList();
            //foreach (Subsciber sub in subscibers)
            //{
            //    await Helper.SendMessageAsync("New Teacher", Massage, sub.Email);
            //}
           
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).Include(x=>x.Skills).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            
           
            return View(teacher);
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Teacher teacher)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            Teacher teacherDb = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).Include(x=>x.Skills).FirstOrDefault(t => t.Id == id);
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
            foreach (var skill in teacher.Skills)
            {
                foreach (var Dbskill in teacherDb.Skills)
                {
                    Dbskill.Name = skill.Name;
                    Dbskill.Percentage = skill.Percentage;
                }
            }



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
