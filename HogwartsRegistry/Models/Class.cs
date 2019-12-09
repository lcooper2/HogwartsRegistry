using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    // A class is a specific instance of a course that is associated with an instructor. Students associate with a class
    // when they register for classes.
    public class Class
    {
        public int Id { get; set; }
        public int CRN { get; set; }
        public string Term { get; set; }
        public string InstructorId { get; set; }
        public int CourseId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [ForeignKey("InstructorId")]
        public virtual Instructor Instructor { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
 
}