using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Course
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DetailCourse DetailCourse { get; set; }
    }
}
