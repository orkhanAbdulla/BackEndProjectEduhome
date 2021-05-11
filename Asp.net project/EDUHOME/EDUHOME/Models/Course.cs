using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DetailCourse DetailCourse { get; set; }
    }
}
