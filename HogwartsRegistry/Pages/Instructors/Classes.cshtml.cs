using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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
        public List<Course> Courses { get; set; }
        public void OnGet(string instructorId)
        {
            if (instructorId == null)
            {
                var ClaimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                instructorId = claim.Value;
            }
            Classes = _db.Classes
                        .Include(c => c.Course)
                        .Where(c => c.InstructorId == instructorId)
                        .ToList();
        }

        public async Task<IActionResult> OnPostDelete(int classId)
        {
            Class toDelete = await _db.Classes.FindAsync(classId);
            _db.Classes.Remove(toDelete);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}