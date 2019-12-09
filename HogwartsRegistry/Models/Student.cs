using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class Student : ApplicationUser
    {
        public int StudentId { get; set; } // Like a W number
        public int Year { get; set; }
        public bool IsMudBlood { get; set; }
        public string House { get; set; }
    }
}
