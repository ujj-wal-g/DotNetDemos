﻿// <auto-generated />
using ConventionDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConventionDemo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220203055204_CreateEFSchoolDb")]
    partial class CreateEFSchoolDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("ConventionDemo.Student", b =>
                {
                    b.HasOne("ConventionDemo.Grade", "Grade")
                        .WithMany("students")
                        .HasForeignKey("currentGradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("ConventionDemo.Grade", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
