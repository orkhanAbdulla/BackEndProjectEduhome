using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState== ModelValidationState.Invalid) return View();
            if (!slider.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image type!!!");
                return View();
            }
            if (slider.Photo.IsValidSize(500))
            {
                ModelState.AddModelError("Photo", "Please select image size less than 200kb!!!");
                return View();
            }
            string path= Path.Combine("img","slider");
            slider.ImageUrl = await slider.Photo.SavaFileAsync(_env.WebRootPath, path);
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

           return View(slider);
        }
       [HttpPost]
       [ValidateAntiForgeryToken]
       [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            string path = Path.Combine(_env.WebRootPath, "img","slide", slider.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        }
    }
}
