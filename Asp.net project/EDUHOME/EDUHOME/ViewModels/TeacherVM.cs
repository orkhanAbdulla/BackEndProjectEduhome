using EDUHOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewModels
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public List<string> SkillName{ get; set; }
        public List<int> SkillPercentage { get; set; }
    }
}
