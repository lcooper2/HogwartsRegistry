using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using HogwartsRegistry.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public IndexModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IQueryable<Instructor> Instructors { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Instructors = _db.Instructors;
            return Page();
        }

        public async Task<IActionResult> OnPostDelete(string id)
        {
            // We have to delete the classes that the instructor teaches before we can delete an instructor
            List<Class> instructorClasses = _db.Classes.Where(cls => cls.InstructorId == id).ToList();
            _db.Classes.RemoveRange(instructorClasses);

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