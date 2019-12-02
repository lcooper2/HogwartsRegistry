using System;
using System.Collections.Generic;
using System.Text;
using HogwartsRegistry.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HogwartsRegistry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set;}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<StudentClasses> StudentClasses { get; set; }
    }
}
