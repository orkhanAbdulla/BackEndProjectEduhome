using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class DetailCourse
    {
        public int Id { get; set; }
        public string AboutCourse { get; set; }
        public string HowToApply { get; set; }
        [Required, MaxLength(155)]
        public DateTime Starts { get; set; }
        [Required, MaxLength(155)]
        public string Duration { get; set; }
        [Required, MaxLength(155)]
        public string ClassDuration { get; set; }
        [Required, MaxLength(155)]
        public string SkillLevel { get; set; }
        [Required, MaxLength(155)]
        public string Language { get; set; }
        [Required, MaxLength(155)]
        public int Students { get; set; }
        [Required, MaxLength(155)]
        public string Assesments { get; set; }
        [Required,MaxLength(155)]
        public int Price { get; set; }
        public string Certification { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
