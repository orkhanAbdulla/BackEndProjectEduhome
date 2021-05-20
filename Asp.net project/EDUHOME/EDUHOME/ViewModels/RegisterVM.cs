using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.ViewModels
{
    public class RegisterVM
    {
        [Required,MaxLength(255)]
        public string Name { get; set; }
         [Required,MaxLength(255)]
        public string Surname { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required, MaxLength(255),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(255),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password),Compare(nameof(Password))]
        public string CheckPassword { get; set; }

    }
}
