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
    //[Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
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
            Event Eve = _context.Events.Include(e => e.EventDetail).Include(e => e.EventSpeakers).ThenInclude(es => es.Speaker).FirstOrDefault(e => e.Id == id);
            if (Eve == null) return NotFound();
            return View(Eve);
        }
        public IActionResult Search(string searchh)
        {
            List<Event> events = _context.Events.Where(x => x.IsDeleted == false && x.Lesson.ToLower().Trim().Contains(searchh.ToLower().Trim())).ToList();
            return PartialView("_EventPartial", events);
        }
    }
}
