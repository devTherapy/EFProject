using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFProject.Models
{
    public class Employee
    {
        public Employee()
        {
            HireDate = DateTime.Now;
        }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public Department EmployeeDepartment { get; set; }
    }
}
