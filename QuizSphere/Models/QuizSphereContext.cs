using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuizSphere.Models
{
    public partial class QuizSphereContext : DbContext
    {
        public QuizSphereContext()
        {
        }

        public QuizSphereContext(DbContextOptions<QuizSphereContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attempt> Attempts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Option> Options { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Quiz> Quizzes { get; set; } = null!;
        public virtual DbSet<Users> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attempt>(entity =>
            {
                entity.HasKey(e => e.AttemptsId);

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.Property(e => e.Score).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubmittedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QuestionsId);

                entity.Property(e => e.QuestionsId).HasColumnName("QuestionsID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.HasKey(e => e.QuizzesId);

                entity.Property(e => e.QuizzesId).HasColumnName("QuizzesID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Password).HasMaxLength(150);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
