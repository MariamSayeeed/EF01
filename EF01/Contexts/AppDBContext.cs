using EF01.Configurations;
using EF01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.MyDBContext
{
    internal class AppDBContext : DbContext 
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Instructor Class -> Fluent API
            modelBuilder.Entity<Instructor>().HasKey(I=>I.Id);
            modelBuilder.Entity<Instructor>().Property(I=>I.Name).HasMaxLength(50);
            modelBuilder.Entity<Instructor>().Property(I=>I.Salary).HasDefaultValue(10000);

            //--------------------
            // Student Class -> Class Configuration
            modelBuilder.ApplyConfiguration(new StudentConfig());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MARIAM\\SQLSERVER2022; Database= ITIEF01; Trusted_Connection = True; TrustServerCertificate = True"); 
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; } 

    }
}
