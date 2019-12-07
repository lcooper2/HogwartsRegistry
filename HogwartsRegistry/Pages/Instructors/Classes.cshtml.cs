using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogwartsRegistry.Pages.Instructors
{
    public class ClassesModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public ClassesModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<Class> Classes { get; set; }
        public void OnGet(string instructorId)
        {
            //Classes = _db.Classes.Where(c => c.InstructorId == instructorId)
        }
    }
}