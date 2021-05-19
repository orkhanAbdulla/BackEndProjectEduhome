using EDUHOME.DAL;
using EDUHOME.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.socials).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();

            return View(teacher);
        }
    }
}
