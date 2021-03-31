using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Not specified Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Not specified FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Not specified LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Not specified Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password entered incorrectly")]
        public string ConfirmPassword { get; set; }
    }
}
