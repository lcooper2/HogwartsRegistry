using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class StudentClasses
    {
        public int Id { get; set; }
        public string StudentId { get; set; } // Student.Id
        public int ClassId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
    }
}
