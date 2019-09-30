using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public char Gender { get; set; }
    }
}
