using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Social
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Link { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
