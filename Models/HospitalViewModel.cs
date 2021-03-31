using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class HospitalViewModel
    {
    
        public string HospitalName { get; set; }
        public IFormFile HospitalImage { get; set; }
    }
}
