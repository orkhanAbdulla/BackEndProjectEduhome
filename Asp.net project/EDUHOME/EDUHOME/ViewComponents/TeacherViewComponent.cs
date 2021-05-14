using EDUHOME.DAL;
using EDUHOME.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewComponents
{
    public class TeacherViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public TeacherViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Teacher> model = _context.Teachers.Include(t=>t.TeacherSocials).ThenInclude(ts=>ts.Social).Take(take).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
