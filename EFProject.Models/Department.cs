using System;
using System.Collections.Generic;
using System.Text;

namespace EFProject.Models
{
    public class Department
    {
        public string DepartmentId { get; set; }
        public string Name { get; set; }
        public ICollection<Employee>ListOfEmployees { get; set; }
    }
}
