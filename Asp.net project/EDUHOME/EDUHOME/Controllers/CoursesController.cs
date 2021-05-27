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
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
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
            Course course = _context.Courses.Include(c => c.DetailCourse).FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
          
            return View(course);
        }
        public IActionResult Search(string search)
        {
            List<Course> courses = _context.Courses.Where(x=>x.IsDeleted==false&&x.Name.ToLower().Trim().Contains(search.ToLower().Trim())).ToList();
            return PartialView("_CoursePartial",courses);
        }
    }
    
}
