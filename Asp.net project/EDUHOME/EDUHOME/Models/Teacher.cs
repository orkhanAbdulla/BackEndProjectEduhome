using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, MaxLength(155)]
        public string ImageUrl { get; set; }
        [Required,MaxLength(155)]
        public string Fullname { get; set; }
        [Required, MaxLength(155)]
        public string Position { get; set; }
    }
}
