using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using HogwartsRegistry.Utility;

namespace HogwartsRegistry.Pages.Instructors
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class CreateClassModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _context;

        public CreateClassModel(HogwartsRegistry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // Add a class for the currently logged in instructor
        public IActionResult OnGet()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "CourseTitle");
            List<Class> classes = _context.Classes.Include(c => c.Course).ToList();
            return Page();
        }

        [BindProperty]
        public Class Class { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            var ClaimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string instructorId = claim.Value;
            Class.InstructorId = instructorId;

            _context.Classes.Add(Class);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Instructors/Classes");
        }
    }
}