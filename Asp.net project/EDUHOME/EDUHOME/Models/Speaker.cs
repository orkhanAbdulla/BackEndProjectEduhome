using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Fullname { get; set; }
        public string Occupation { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
