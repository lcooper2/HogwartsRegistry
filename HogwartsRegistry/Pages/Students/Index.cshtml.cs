using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Student> Student { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Student = await _db.Students.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if(student == null)
            {
                return NotFound();
            }
            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}