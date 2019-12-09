using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models.ViewModels
{
    public class InstructorViewStudentsViewModel
    {
        public Class Class { get; set; }
        public List<StudentClasses> Students { get; set; }
        public List<Student> otherStudents { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
