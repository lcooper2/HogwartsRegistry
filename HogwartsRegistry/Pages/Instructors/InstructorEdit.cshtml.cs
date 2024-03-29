﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HogwartsRegistry.Data;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Authorization;
using HogwartsRegistry.Utility;

namespace HogwartsRegistry.Pages.Instructors
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class InstructorEditModel : PageModel
    {
        private readonly HogwartsRegistry.Data.ApplicationDbContext _db;

        public InstructorEditModel(HogwartsRegistry.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instructor = await _db.Instructors.FirstOrDefaultAsync(m => m.Id == id);

            if (Instructor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_db.Attach(Instructor).State = EntityState.Modified;

            try
            {
                Instructor instructorFromDb = await _db.Instructors.FirstOrDefaultAsync(m => m.Id == Instructor.Id);
                instructorFromDb.FirstName = Instructor.FirstName;
                instructorFromDb.LastName = Instructor.LastName;
                instructorFromDb.Department = Instructor.Department;
                instructorFromDb.NumYearsWorked = Instructor.NumYearsWorked;
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
                if (!InstructorExists(Instructor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
                
            }

            return RedirectToPage("./Index");
        }

        private bool InstructorExists(string id)
        {
            return _db.Instructors.Any(e => e.Id == id);
        }
    }
}
