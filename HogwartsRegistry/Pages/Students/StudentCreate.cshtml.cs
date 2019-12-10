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

namespace HogwartsRegistry.Pages.Students
{
    [Authorize]
    public class StudentCreateModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _context;

        public StudentCreateModel(HogwartsRegistry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Select can only pass strings so convert it to bool
            Student.Gender = Convert.ToBoolean(Request.Form["Gender"]); 
            Random random = new Random();
            Student.StudentId = random.Next(10000000, 99999999); // Randomly generate the student a studentId
            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}