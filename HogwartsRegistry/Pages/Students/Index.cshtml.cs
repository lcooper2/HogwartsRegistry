using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using HogwartsRegistry.Models.ViewModels;
using HogwartsRegistry.Utility;
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

        [BindProperty]
        public StudentListViewModel StudentListViewModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int studentPage = 1, string searchLastName = null, string searchYear = null, string searchHouse = null)
        {
            StudentListViewModel = new StudentListViewModel()
            {
                StudentList = await _db.Students.ToListAsync()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Students?studentPage=:");

            if (searchLastName != null)
            {
                param.Append("&searchLastName=");
                param.Append(searchLastName);
                StudentListViewModel.StudentList = StudentListViewModel.StudentList.Where(s => s.LastName == searchLastName).ToList();
            }

            if (searchYear != null)
            {
                param.Append("&searchYear=");
                param.Append(searchYear);
                StudentListViewModel.StudentList = StudentListViewModel.StudentList.Where(s => s.Year == Convert.ToInt32(searchYear)).ToList();
            }

            if(searchHouse != null)
            {
                param.Append("&searchHouse=");
                param.Append(searchHouse);
                StudentListViewModel.StudentList = StudentListViewModel.StudentList.Where(s => s.House == searchHouse).ToList();
            }

            var count = StudentListViewModel.StudentList.Count;

            StudentListViewModel.PagingInfo = new PagingInfo()
            {
                CurrentPage = studentPage,
                ItemsPerPage = SD.PaginationUserPageSize,
                TotalItems = count,
                UrlParameters = param.ToString()
            };

            StudentListViewModel.StudentList = StudentListViewModel.StudentList
                .OrderBy(u => u.LastName)
                .Skip((studentPage - 1) * SD.PaginationUserPageSize)
                .Take(StudentListViewModel.PagingInfo.ItemsPerPage).ToList();

            return Page();
        }



        public async Task<IActionResult> OnPostDelete(string id)
        {
            // Delete all student enrollments before deleting the student
            List<StudentClasses> classes = _db.StudentClasses.Where(s => s.StudentId == id).ToList();
            _db.RemoveRange(classes);

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