using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FluentAPIDemo2
{
    internal class MyDbContext :DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        ////@ Entity Configuration
        ////ToTable(To configure the table)
        modelBuilder.Entity<Department>().ToTable("Dept");


            //    //HashKey(To configure the Primary Key)
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);
            modelBuilder.Entity<EmployeeAddress>().HasKey(d => d.EmployeeId);

            //    //@Property Configuration 
            //    modelBuilder.Entity<Employee>().Property(e => e.EmployeeId);

            //    //HasColoumnName (To configure the column name)
            //    modelBuilder.Entity<Employee>().Property(e => e.EmpName).HasColumnName("Ename")
            //                                                            .IsRequired()
            //                                                            .HasMaxLength(50)
            //                                                            .HasColumnType("varchar");

            //    modelBuilder.Entity<Employee>().Property(ea => ea.PrimaryContact).IsRequired()
            //                                                                     .HasMaxLength(10);

            //    //D
            //    //modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
            //    modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeAddress);
            //    //One to One Relationship between employee and EmployeeAddress

            //    //modelBuilder.Entity<Employee>().HasOne(e => e.EmployeeAddress);






        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5NEPIAJ;Database=EmployeeDB;Trusted_Connection=True;");
        }

    }
}
