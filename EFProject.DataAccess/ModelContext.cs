using System;
using System.Collections.Generic;
using System.Text;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;
namespace EFProject.DataAccess
{
   public class ModelContext : DbContext 
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source =.; Initial Catalog = DepartmentData Database; Integrated Security = True");
        }
    }
}
