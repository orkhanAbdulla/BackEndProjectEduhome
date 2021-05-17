using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Models;
using EDUHOME.ViewModels;
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
    public class EventAdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public EventAdminController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Event> Event = _context.Events.Include(e => e.EventDetail).Include(e => e.EventSpeakers).ThenInclude(e => e.Speaker).ToList();
            return View(Event);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Event Event = _context.Events.Include(e => e.EventDetail).Include(e => e.EventSpeakers).ThenInclude(es => es.Speaker).FirstOrDefault(e => e.Id == id);
            if (Event == null) return NotFound();

            return View(Event);
        }
        public IActionResult Create()
        {
            ViewBag.Speakers = _context.Speakers.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM)
        {
            ViewBag.Speakers = _context.Speakers.ToList();

            
            if (!ModelState.IsValid) return View();

            if (eventVM.Event.Photo == null)
            {
                ModelState.AddModelError("Event.Photo", "Please select Photo");
                return View();
            }
            if (!eventVM.Event.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Event.Photo", "Please select image Type");
                return View();
            }
            if (!eventVM.Event.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Event.Photo", "Please select image Size less than kb");
                return View();
            }
            if (eventVM.Speakers == null)
            {
                ModelState.AddModelError("Speakers", "Please Select Speakers");
                return View();
            }
            string path = Path.Combine("img", "event");
            eventVM.Event.ImageUrl = await eventVM.Event.Photo.SavaFileAsync(_env.WebRootPath, path);

            await _context.Events.AddAsync(eventVM.Event);
            await _context.SaveChangesAsync();
           

            eventVM.EventDetail.EventId = eventVM.Event.Id;




            EventSpeaker eventSpeaker = new EventSpeaker();
            eventSpeaker.EventId = eventVM.Event.Id;
            foreach (int sp in eventVM.Speakers)
            {
                eventSpeaker.SpeakerId = sp;
                await _context.EventSpeakers.AddAsync(eventSpeaker);
            }
            
      
            await _context.EventDetail.AddAsync(eventVM.EventDetail);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}
