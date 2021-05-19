using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string İmageUrl { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
        public int Comment { get; set; }
        public string Tittle { get; set; }
        public BlogDetail BlogDetail { get; set; }
    }
}
