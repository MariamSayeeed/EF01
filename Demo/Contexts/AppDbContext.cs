using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class AppDbContext : DbContext
    {


        //Microsoft.EntityFrameworkCore
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //modelBuilder.Entity<Employee>().HasKey("EmpId");//Not recommended
        //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
        //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.Name)
        //            .IsRequired(true)
        //            .HasColumnType(typeName:"varchar")
        //            .HasMaxLength(maxLength:50)
        //            .HasColumnName(name:"EmployeeName");

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.Age)
        //            .IsRequired(requied:false);

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.Salary)
        //            .HasColumnType(typeName:"money");

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.DateOfCreation)
        //            .HasDefaultValue(DateTime.Now);

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.DateOfCreation)
        //            .HasDefaultValueSql(sql:"GETDATE()");


        //    modelBuilder.Entity<Employee>(E =>
        //    {
        //        E.HasKey(E => E.EmpId);
        //        E.Property(E => E.Name)
        //         .IsRequired(true)
        //         .HasColumnType("varchar")
        //         .HasMaxLength(50)
        //         .HasColumnName("EmployeeName");

        //        E.Property(E => E.Age).IsRequired(false);

        //        E.Property(E => E.Salary).HasColumnType("money");

        //        E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");

        //    });

        //    modelBuilder.ApplyConfiguration(new EmployeeConfigurations());

        //    base.OnModelCreating(modelBuilder);

        //}
        public AppDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MARIAM\\SQLSERVER2022; Database = AppG05; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }

}
