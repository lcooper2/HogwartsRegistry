using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Instructor> Instructors { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Instructors = await _db.Instructors.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var instructor = await _db.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }
            _db.Instructors.Remove(instructor);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}