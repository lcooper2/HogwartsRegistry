using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Courses
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Course> Courses { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Courses = await _db.Courses.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}