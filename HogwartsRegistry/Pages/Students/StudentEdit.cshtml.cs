using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Authorization;

namespace HogwartsRegistry.Pages.Students
{
    [Authorize]
    public class StudentEditModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _context;

        public StudentEditModel(HogwartsRegistry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            try
            {
                Student dbStudent = await _context.Students.FirstOrDefaultAsync(i => i.Id == Student.Id);
                dbStudent.FirstName = Student.FirstName;
                dbStudent.LastName = Student.LastName;
                dbStudent.Year = Student.Year;
                dbStudent.House = Student.House;
                dbStudent.IsMudBlood = Student.IsMudBlood;
                dbStudent.StudentId = Student.StudentId;
                dbStudent.Gender = Student.Gender;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!StudentExists(Student.Id))
                {
                    return NotFound();
                }
                else
                {
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentExists(string id)
        {
            return _context.Students.Any(e => e.Id == id.ToString());
        }
    }
}
