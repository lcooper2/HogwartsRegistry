using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Pages.Students
{
    public class StudentClassesModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public StudentClassesModel(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public void OnGet(string studentId)
        {
            // How to write this in linq?
            /*
            select s.Id, s.firstName, s.lastName, co.DepartmentPrefix, co.CourseNum, CourseTitle
            from StudentClasses sc
            INNER JOIN Class c on sc.ClassId = c.Id
            INNER JOIN Course co on c.CourseId = co.Id
            INNER JOIN Student s on sc.StudentId = s.Id
            WHERE sc.StudentId = studentId
            */

            // Need to only show classes for logged in user if user is not admin
            // Show list of students with option to view classes if user is admin 
        }
    }
}