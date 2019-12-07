using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models.ViewModels
{
    public class RegisterClassesViewModel
    {
        public Student Student { get; set; }
        public List<Class> Classes { get; set; }
        public int MyProperty { get; set; }
    }
}
