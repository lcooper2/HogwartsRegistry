using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{

    // A course is the name, credit hours, and department associated with a class. It is not associated with an instructor.
    public class Course
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string DepartmentPrefix { get; set; }
        public int CourseNum { get; set; }
        public string CourseTitle { get; set; }
        public string CreditHours { get; set; }
    }
}
