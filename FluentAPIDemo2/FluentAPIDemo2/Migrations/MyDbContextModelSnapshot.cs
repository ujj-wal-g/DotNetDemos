﻿// <auto-generated />
using FluentAPIDemo2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentAPIDemo2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsProjectId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "ProjectsProjectId");

                    b.HasIndex("ProjectsProjectId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("FluentAPIDemo2.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"), 1L, 1);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Dept", (string)null);
                });

            modelBuilder.Entity("FluentAPIDemo2.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentDeptId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrimaryContact")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentDeptId");

                    b.HasIndex("TeamId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FluentAPIDemo2.EmployeeAddress", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeAddresses");
                });

            modelBuilder.Entity("FluentAPIDemo2.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("Database")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FluentAPIDemo2.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamSize")
                        .HasColumnType("int");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("FluentAPIDemo2.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentAPIDemo2.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FluentAPIDemo2.Employee", b =>
                {
                    b.HasOne("FluentAPIDemo2.Department", "Department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentDeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentAPIDemo2.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FluentAPIDemo2.EmployeeAddress", b =>
                {
                    b.HasOne("FluentAPIDemo2.Employee", "Employee")
                        .WithOne("EmployeeAddress")
                        .HasForeignKey("FluentAPIDemo2.EmployeeAddress", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FluentAPIDemo2.Department", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("FluentAPIDemo2.Employee", b =>
                {
                    b.Navigation("EmployeeAddress")
                        .IsRequired();
                });

            modelBuilder.Entity("FluentAPIDemo2.Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
