using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using HogwartsRegistry.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Students
{
    [Authorize]
    public class StudentClassesModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public StudentClassesModel(ApplicationDbContext db)
        {
            _db = db;
        }

        
        [BindProperty]
        public List<StudentClasses> studentClasses { get; set; }
        public void OnGet(string studentId)
        {
            if(studentId == null)
            {
                var ClaimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                studentId = claim.Value;
            }
            studentClasses = _db.StudentClasses
                                .Include(s => s.Class)
                                .Include(s => s.Class.Course)
                                .Include(s => s.Class.Instructor)
                                .Where(s => s.StudentId == studentId)
                                .ToList();
            
        }
    }
}