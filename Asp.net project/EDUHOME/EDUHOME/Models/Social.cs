using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Social
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public ICollection<TeacherSocial> TeacherSocials { get; set; }

    }
}
