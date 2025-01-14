﻿// <auto-generated />
using System;
using EFProject.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFProject.DataAccess.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20210207145741_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EFProject.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("DepartMents");
                });

            modelBuilder.Entity("EFProject.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId")
                        .IsUnique()
                        .HasFilter("[DepartmentId] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFProject.Models.Employee", b =>
                {
                    b.HasOne("EFProject.Models.Department", "EmployeeDepartment")
                        .WithOne("EmployeeInDepartment")
                        .HasForeignKey("EFProject.Models.Employee", "DepartmentId");

                    b.Navigation("EmployeeDepartment");
                });

            modelBuilder.Entity("EFProject.Models.Department", b =>
                {
                    b.Navigation("EmployeeInDepartment");
                });
#pragma warning restore 612, 618
        }
    }
}
