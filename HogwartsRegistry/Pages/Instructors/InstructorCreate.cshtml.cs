using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Authorization;
using HogwartsRegistry.Utility;

namespace HogwartsRegistry.Pages.Instructors
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class InstructorCreateModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _db;

        public InstructorCreateModel(HogwartsRegistry.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Instructors.Add(Instructor);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}