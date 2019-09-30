using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;

namespace HogwartsRegistry.Pages.Courses
{
    public class CourseCreateModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _db;

        public CourseCreateModel(HogwartsRegistry.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Courses.Add(Course);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}