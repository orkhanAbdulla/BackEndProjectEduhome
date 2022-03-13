using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
        public string ImageUrl { get; set; }
        [Required,MaxLength(155)]
        public string Fullname { get; set; }
        [Required, MaxLength(155)]
        public string Position { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public List<Social> socials { get; set; }
        public IList<Skill> Skills { get; set; }


    }
}
