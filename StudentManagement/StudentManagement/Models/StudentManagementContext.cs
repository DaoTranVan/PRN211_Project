using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace StudentManagement.Models
{
    public partial class StudentManagementContext : DbContext
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("SMConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.ClassDesc)
                    .HasColumnType("text")
                    .HasColumnName("class_desc");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("class_name");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("major_id");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_Class_Major");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender_name");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("major_id");

                entity.Property(e => e.MajorDesc)
                    .HasColumnType("text")
                    .HasColumnName("major_desc");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("major_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("major_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("student_address");

                entity.Property(e => e.StudentDob)
                    .HasColumnType("date")
                    .HasColumnName("student_dob");

                entity.Property(e => e.StudentImg)
                    .HasColumnType("text")
                    .HasColumnName("student_img");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("student_name");

                entity.Property(e => e.StudentPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_phone");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Student_Class");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Student_Gender");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_Student_Major");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Student_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
