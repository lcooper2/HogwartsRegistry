using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class Instructor : ApplicationUser
    {
        public string Department { get; set; }
        public int NumYearsWorked { get; set; }
    }
}
