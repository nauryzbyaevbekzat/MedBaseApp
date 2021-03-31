using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Not specified Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Not specified Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
