using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }

     

        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        internal static object FindFirst(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
