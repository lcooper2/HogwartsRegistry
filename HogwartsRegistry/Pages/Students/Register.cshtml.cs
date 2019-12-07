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

namespace HogwartsRegistry.Pages.Students
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public RegisterModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<Class> otherClasses { get; set; }
        public List<StudentClasses> studentClasses { get; set; }

        public void OnGet(string studentId)
        {
            if (studentId == null)
            {
                var ClaimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                studentId = claim.Value;
            }
            // Get a list of classes the user is enrolled in.
            studentClasses = _db.StudentClasses
                                .Include(s => s.Class)
                                .Include(s => s.Class.Course)
                                .Include(s => s.Class.Instructor)
                                .Where(s => s.StudentId == studentId)
                                .ToList();

            // Get the class Id of every class the current student is enrolled in.
            IEnumerable<int> classIds = from s in studentClasses
                                        select s.ClassId;

            // Get a list of every other class that the student is not enrolled in to display.
            // We don't want the student to be able to enroll in the same class twice.
            otherClasses = _db.Classes
                                .Include(s => s.Course)
                                .Include(s => s.Instructor)
                                .Where(s => !classIds.Contains(s.Id))
                                .ToList();
        }

        // Effectively unenrolls a student in a class
        public async Task<IActionResult> OnPostDelete(string studentId, int classId)
        {
            if (studentId == null)
            {
                var ClaimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                studentId = claim.Value;
            }
            StudentClasses studentClass = _db.StudentClasses.FirstOrDefault(s => (s.StudentId == studentId) && (s.ClassId == classId));
            _db.StudentClasses.Remove(studentClass);
            await _db.SaveChangesAsync();
            return RedirectToPage("Register", new { studentId = studentId });
        }

        public async Task<IActionResult> OnPostEnroll(string studentId, int classId)
        {
            if (studentId == null)
            {
                var ClaimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                studentId = claim.Value;
            }
            StudentClasses studentClass = new StudentClasses
            {
                StudentId = studentId,
                ClassId = classId
            };
            _db.StudentClasses.Add(studentClass);
            await _db.SaveChangesAsync();
            return RedirectToPage("Register", new { studentId = studentId });
        }
    }
}