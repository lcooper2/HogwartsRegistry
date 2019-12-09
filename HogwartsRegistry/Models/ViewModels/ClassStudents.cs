using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models.ViewModels
{
    public class ClassStudents
    {
        public int classId { get; set; }
        public List<Student> Students { get; set; }
    }
}
