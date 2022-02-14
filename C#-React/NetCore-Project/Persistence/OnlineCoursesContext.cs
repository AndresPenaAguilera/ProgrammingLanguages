using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class OnlineCoursesContext: DbContext
    {
        public OnlineCoursesContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseInstructor>().HasKey( ci => new { ci.InstructorId, ci.CourseId });
        }

        public DbSet<Comment> Comment {get; set;}
        public DbSet<Course> Course {get; set;}
        public DbSet<CourseInstructor> CourseInstructor {get; set;}
        public DbSet<Instructor> Instructor {get; set;}
        public DbSet<Price> Price {get; set;}
        
    }
}
