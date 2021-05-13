using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string ImageUrl { get; set; }
        [Required,MaxLength(150)]
        public string Lesson { get; set; }
        [Required, MaxLength(150)]
        public string Venue { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public EventDetail EventDetail { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }

    }
}
