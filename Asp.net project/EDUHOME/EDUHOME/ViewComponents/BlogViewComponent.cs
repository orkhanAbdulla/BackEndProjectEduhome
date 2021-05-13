using EDUHOME.DAL;
using EDUHOME.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Blog> model = _context.Blogs.Take(take).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
