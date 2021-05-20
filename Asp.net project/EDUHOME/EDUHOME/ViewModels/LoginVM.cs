using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewModels
{
    public class LoginVM
    {
        [Required,StringLength(255)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password), StringLength(255)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
