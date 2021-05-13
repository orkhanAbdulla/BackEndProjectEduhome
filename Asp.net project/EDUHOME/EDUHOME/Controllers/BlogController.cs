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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
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
            Blog blog = _context.Blogs.Include(b => b.BlogDetail).FirstOrDefault(b => b.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
