using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public char Gender { get; set; }
        public int Year { get; set; }
        public bool IsMudBlood { get; set; }
        public string House { get; set; }
    }
}
