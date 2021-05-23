using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDUHOME.Models
{
    public class Subsciber
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
