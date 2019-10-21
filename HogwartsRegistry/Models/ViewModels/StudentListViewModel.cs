using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models.ViewModels
{
    public class StudentListViewModel
    {
        public List<Student> StudentList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
