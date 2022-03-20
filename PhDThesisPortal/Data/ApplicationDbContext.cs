using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhDThesisPortal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhDThesisPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyIdentityUser,MyIdentityRole,Guid>
    {
        public DbSet<Department> Departments { get; set; }

       // public DbSet<Subject> Subjects { get; set; }

        //public DbSet<Student> Students { get; set; }

       // public DbSet<Faculty> Faculties { get; set; }
       // public DbSet<Project> Project { get; set; }

        
        public DbSet<SubmissionDetail>  SubmissionDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
