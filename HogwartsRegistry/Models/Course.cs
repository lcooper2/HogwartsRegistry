using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsRegistry.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int CRN { get; set; }
        public string Subject { get; set; }
        
        // Will contain both starting date and starting time of class
        public DateTime StartTime { get; set; }

        // Will contain both ending date and ending time of class
        public DateTime EndTime { get; set; }
    }
}
