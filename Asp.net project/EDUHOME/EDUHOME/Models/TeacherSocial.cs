using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class TeacherSocial
    {
        public int Id { get; set; }
        public int SocialId { get; set; }
        public virtual Social Social { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
  
    }
}
