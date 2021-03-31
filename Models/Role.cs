using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }


    }
}
