using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionDemo.Data
{
   class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5NEPIAJ;Database=EFSchoolDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many relationship
            modelBuilder.Entity<Student>()
                        .HasOne(s=>s.Grade)
                        .WithMany(g=>g.students)
                        .HasForeignKey(s=>s.currentGradeId);
            //One to one relationship
            modelBuilder.Entity<Employee>()
                        .HasOne(s => s.Address)
                        .WithOne(s => s.Employee);
            // Many to Many relationship
            modelBuilder.Entity<AspirantCourse>()
                        .HasKey(s => new { s.AspId, s.CourseId }); 

            modelBuilder.Entity<AspirantCourse>()
                        .HasOne(s => s.Aspirant)
                        .WithMany(s=>s.AspirantCourses)
                        .HasForeignKey(sc=>sc.AspId);
            modelBuilder.Entity<AspirantCourse>()
                        .HasOne(s => s.Course)
                        .WithMany(s => s.AspirantCourses)
                        .HasForeignKey(sc => sc.CourseId);

        }
       

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EmployeeAddress> employeeAddreses { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Aspirant>aspirants { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<AspirantCourse> aspirantscourses { get; set;}
    }
}
