using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedBaseApp.Models
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.hospitals.Any())
            {
                context.hospitals.AddRange(
                    
                );
                context.SaveChanges();
            }
        }

    }
}
