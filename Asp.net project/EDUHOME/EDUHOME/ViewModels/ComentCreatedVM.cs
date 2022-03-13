using EDUHOME.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewModels
{
    public class ComentCreatedVM
    {
        public string AppUserId { get; set; }
        public int Rate { get; set; }
        public int CourseId { get; set; }
        [Required]
        public string Messgae { get; set; }
        public AppUser AppUser { get; set; }
        public Course Course { get; set; }
    }
}
