using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string İmageUrl { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public int Comment { get; set; }
        public string Tittle { get; set; }
        public BlogDetail BlogDetail { get; set; }
    }
}
