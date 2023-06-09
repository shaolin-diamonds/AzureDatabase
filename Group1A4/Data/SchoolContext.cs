﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Group1A4.Models;

namespace Group1A4.Data
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.HasIndex(e => e.CourseId, "UQ__Class__8F1EF7AFFCB8667C")
                    .IsUnique();

                entity.HasIndex(e => e.InstructorId, "UQ__Class__A1EF56E9B7013CF2")
                    .IsUnique();

                entity.HasIndex(e => e.ClassId, "UQ__Class__FDF4798764D4BF57")
                    .IsUnique();

                entity.Property(e => e.ClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("class_id");

                entity.Property(e => e.ClassCredits).HasColumnName("class_credits");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_name");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.InstructorId).HasColumnName("instructor_id");

                entity.HasOne(d => d.Course)
                    .WithOne(p => p.Class)
                    .HasForeignKey<Class>(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course");

                entity.HasOne(d => d.Instructor)
                    .WithOne(p => p.Class)
                    .HasForeignKey<Class>(d => d.InstructorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.HasIndex(e => e.StudentId, "UQ__Course__2A33069B858CD018")
                    .IsUnique();

                entity.HasIndex(e => e.CourseId, "UQ__Course__8F1EF7AF2D634BBF")
                    .IsUnique();

                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("course_id");

                entity.Property(e => e.CourseDate)
                    .HasColumnType("date")
                    .HasColumnName("course_date");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("course_name");

                entity.Property(e => e.CoursePrice).HasColumnName("course_price");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.Course)
                    .HasForeignKey<Course>(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shirt");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");

                entity.HasIndex(e => e.InstructorId, "UQ__Instruct__A1EF56E9B0CF22D5")
                    .IsUnique();

                entity.Property(e => e.InstructorId)
                    .ValueGeneratedNever()
                    .HasColumnName("instructor_id");

                entity.Property(e => e.InstructorEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instructor_email");

                entity.Property(e => e.InstructorFname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instructor_fname");

                entity.Property(e => e.InstructorLname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instructor_lname");

                entity.Property(e => e.InstructorRating).HasColumnName("instructor_rating");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.HasIndex(e => e.StudentId, "UQ__Student__2A33069B7EE90A33")
                    .IsUnique();

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("student_id");

                entity.Property(e => e.StudentEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_email");

                entity.Property(e => e.StudentFname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_fname");

                entity.Property(e => e.StudentLname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_lname");

                entity.Property(e => e.StudentZipcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_zipcode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}