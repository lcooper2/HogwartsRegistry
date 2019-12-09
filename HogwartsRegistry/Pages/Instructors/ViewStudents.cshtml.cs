using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using HogwartsRegistry.Models.ViewModels;
using HogwartsRegistry.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Instructors
{
    public class ViewStudentsModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public ViewStudentsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        
        [BindProperty]
        public InstructorViewStudentsViewModel InstrViewVM { get; set; }
        public async Task<IActionResult> OnGet(int classId, int studentPage = 1, string searchLastName = null, string searchYear = null, string searchHouse = null)
        {
            var ClaimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = ClaimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string instructorId = claim.Value;

            InstrViewVM = new InstructorViewStudentsViewModel()
            {
                Class = await _db.Classes.FirstOrDefaultAsync(i => i.Id == classId)
            };

            // Get a list of people enrolled in the current class
            InstrViewVM.Students = _db.StudentClasses
                        .Include(s => s.Student)
                        .Include(s => s.Class.Course)
                        .Where(s => (s.ClassId == classId))
                        .ToList();

            // Get the studentIds of everyone enrolled in the class
            List<string> studentIds = InstrViewVM.Students.Select(s => s.StudentId).ToList();

            InstrViewVM.otherStudents =  
                await _db.Students
                //.Include(s => s.Class)
                //.Include(s => s.Student)
                .Where(s => !studentIds.Contains(s.Id)) // ***
                .ToListAsync();

            StringBuilder param = new StringBuilder();
            param.Append("/Students?studentPage=:");

            if (searchLastName != null)
            {
                param.Append("&searchLastName=");
                param.Append(searchLastName);
                InstrViewVM.otherStudents = InstrViewVM.otherStudents.Where(s => s.LastName == searchLastName).ToList();
            }

            if (searchYear != null)
            {
                param.Append("&searchYear=");
                param.Append(searchYear);
                InstrViewVM.otherStudents = InstrViewVM.otherStudents.Where(s => s.Year == Convert.ToInt32(searchYear)).ToList();
            }

            if (searchHouse != null)
            {
                param.Append("&searchHouse=");
                param.Append(searchHouse);
                InstrViewVM.otherStudents = InstrViewVM.otherStudents.Where(s => s.House == searchHouse).ToList();
            }

            var count = InstrViewVM.otherStudents.Count;

            InstrViewVM.PagingInfo = new PagingInfo()
            {
                CurrentPage = studentPage,
                ItemsPerPage = SD.PaginationUserPageSize,
                TotalItems = count,
                UrlParameters = param.ToString()
            };

            InstrViewVM.otherStudents = InstrViewVM.otherStudents
                .OrderBy(u => u.LastName)
                .Skip((studentPage - 1) * SD.PaginationUserPageSize)
                .Take(InstrViewVM.PagingInfo.ItemsPerPage).ToList();

            return Page();
        }


        public async Task<IActionResult> OnGetUnenrollStudent(int studentClassId)
        {

            StudentClasses classEntry = _db.StudentClasses.Find(studentClassId);
            _db.StudentClasses.Remove(classEntry);
            await _db.SaveChangesAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostEnroll(string studentId)
        {
            if (ModelState.IsValid)
            {
                StudentClasses enrollment = new StudentClasses();
                enrollment.StudentId = studentId;
                enrollment.ClassId = InstrViewVM.Class.Id;
                _db.StudentClasses.Add(enrollment);
                await _db.SaveChangesAsync();
            }
            return Page();
        }
    }
}