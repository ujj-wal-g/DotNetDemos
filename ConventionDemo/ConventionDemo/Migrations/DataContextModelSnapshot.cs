﻿// <auto-generated />
using ConventionDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConventionDemo.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConventionDemo.Aspirant", b =>
                {
                    b.Property<int>("AspId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AspId"), 1L, 1);

                    b.Property<string>("AspName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AspId");

                    b.ToTable("aspirants");
                });

            modelBuilder.Entity("ConventionDemo.AspirantCourse", b =>
                {
                    b.Property<int>("AspId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("AspId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("aspirantscourses");
                });

            modelBuilder.Entity("ConventionDemo.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("ConventionDemo.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"), 1L, 1);

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("ConventionDemo.EmployeeAddress", b =>
                {
                    b.Property<int>("EmpAddressId")
                        .HasColumnType("int");

                    b.Property<string>("EmpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpPinCode")
                        .HasColumnType("int");

                    b.Property<string>("EmpState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpAddressId");

                    b.ToTable("employeeAddreses");
                });

            modelBuilder.Entity("ConventionDemo.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"), 1L, 1);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GradeSection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("ConventionDemo.Student", b =>
                {
                    b.Property<int>("sId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sId"), 1L, 1);

                    b.Property<int>("currentGradeId")
                        .HasColumnType("int");

                    b.Property<string>("sName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sId");

                    b.HasIndex("currentGradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ConventionDemo.AspirantCourse", b =>
                {
                    b.HasOne("ConventionDemo.Aspirant", "Aspirant")
                        .WithMany("AspirantCourses")
                        .HasForeignKey("AspId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConventionDemo.Course", "Course")
                        .WithMany("AspirantCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aspirant");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ConventionDemo.EmployeeAddress", b =>
                {
                    b.HasOne("ConventionDemo.Employee", "Employee")
                        .WithOne("Address")
                        .HasForeignKey("ConventionDemo.EmployeeAddress", "EmpAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ConventionDemo.Student", b =>
                {
                    b.HasOne("ConventionDemo.Grade", "Grade")
                        .WithMany("students")
                        .HasForeignKey("currentGradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("ConventionDemo.Aspirant", b =>
                {
                    b.Navigation("AspirantCourses");
                });

            modelBuilder.Entity("ConventionDemo.Course", b =>
                {
                    b.Navigation("AspirantCourses");
                });

            modelBuilder.Entity("ConventionDemo.Employee", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("ConventionDemo.Grade", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
