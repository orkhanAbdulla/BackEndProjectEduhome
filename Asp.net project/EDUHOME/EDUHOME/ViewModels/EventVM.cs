using EDUHOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public EventDetail EventDetail { get; set;}
        public List<int> Speakers { get; set; }

    }
}
