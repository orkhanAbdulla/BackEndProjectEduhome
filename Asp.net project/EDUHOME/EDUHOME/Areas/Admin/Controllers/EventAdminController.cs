using EDUHOME.DAL;
using EDUHOME.Extensions;
using EDUHOME.Models;
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
        public IActionResult Create()
        {
            ViewBag.Speakers = _context.Speakers.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event Event, int? SpeakerId)
        {
            ViewBag.Speakers = _context.Speakers.ToList();
            if (!ModelState.IsValid) return View();
            if (SpeakerId==null)
            {
                ModelState.AddModelError("", "Please Select Speakers");
                return View();
            }
            if (!Event.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
            }
            if (!Event.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
            }
            string path = Path.Combine("img", "event");
            Event.ImageUrl = await Event.Photo.SavaFileAsync(_env.WebRootPath, path);
            Event.EventDetail.Event = Event;
            Event.EventDetail.EventId = Event.Id;
            foreach (EventSpeaker es in Event.EventSpeakers)
            {
                es.Speaker.Id = (int)SpeakerId;
                es.SpeakerId = (int)SpeakerId;

                await _context.AddRangeAsync(Event, Event.EventDetail, es.Speaker);
            }
           
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}
