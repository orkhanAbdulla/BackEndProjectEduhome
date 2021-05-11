using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Title { get; set; }
        public string TitleBottom { get; set; }
        public string Description { get; set; }
        [Required, StringLength(255)]
        public string ImageUrl { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
