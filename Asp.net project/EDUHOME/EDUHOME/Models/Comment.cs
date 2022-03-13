using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Messgae { get; set; }
        public int Rate { get; set; }
        
        public bool? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public string AppUserId { get; set; }
        public int CourseId { get; set; }
        public AppUser AppUser { get; set; }
        public Course Course { get; set; }

    }
}
