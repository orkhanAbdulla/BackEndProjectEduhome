using EDUHOME.DAL;
using EDUHOME.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewComponents
{
    public class CourseViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> model = _context.Courses.Where(c => c.IsDeleted == false).OrderByDescending(c=>c.Id).Take(take).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
