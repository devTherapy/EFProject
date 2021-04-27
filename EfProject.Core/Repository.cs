using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFProject.DataAccess;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;
namespace EfProject.Core
{
   public class Repository : IRepository
   {
       /// <summary>
       /// Adds an employee to the databse.
       /// </summary>
       /// <param name="salary"></param>
       /// <param name="properties"></param>
       /// <returns>returns the number of rows affected </returns>
        public  int AddEmployee(double salary, params string[] properties)
        {
            string DeptID = FetchDepartmentId(properties[5]);
            CheckForDuplicateEmail(properties[2]);
            using var context = new ModelContext();
            var newEmployee = new Employee
            {
                EmployeeId = Guid.NewGuid().ToString(),
                FirstName = properties[0],
                LastName = properties[1],
                Email = properties[2],
                PhoneNumber = properties[3],
                State = properties[4],
                Salary = salary,
                DepartmentId = DeptID
            };
             
            context.Add<Employee>(newEmployee);
            return context.SaveChanges();
        }
       /// <summary>
       /// deletes an emloyee from the database
       /// </summary>
       /// <param name="ID"></param>
       /// <returns>the number of rows affected</returns>
        public int DeleteEmployee(string ID)
        {
            using var context = new ModelContext();
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == ID);
            if (employee == null)
            {
                throw new Exception("No employee with the given ID");
            }
            context.Employees.Remove(employee);
           return  context.SaveChanges();
        }
        /// <summary>
        /// Finds an employee by a given id
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>the employee</returns>
        public Employee FindEmployeeByID(string ID)
        {
            using var context = new ModelContext();
            var Employee = context.Employees.FirstOrDefault(e => e.EmployeeId == ID);
            if (Employee == null)
            {
                throw new Exception("No employee with the given ID");
            }
            return Employee;
        }
        /// <summary>
        /// Updates an employee in the database
        /// </summary>
        /// <param name="Employee"></param>
        /// <param name="salary"></param>
        /// <param name="properties"></param>
        /// <returns>the number of rows affected</returns>
        public int UpdateEmployee(Employee Employee, double salary, params string[]properties )
        {
            using var context = new ModelContext();
           var emp = context.Employees.FirstOrDefault(e => e.EmployeeId == Employee.EmployeeId);
            emp.FirstName = properties[0];
            emp.LastName = properties[1];
            emp.Email = properties[2];
            emp.PhoneNumber = properties[3];
            emp.State = properties[4];
            emp.DepartmentId = properties[5];
            emp.Salary = salary;
            return  context.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="dept"></param>
        /// <returns></returns>
        public string AddEmployeeToDepartment(Employee employee, string dept)
        {
            string deptId = Guid.NewGuid().ToString();
            using (var context = new ModelContext())
            {
                var department = context.Departments.FirstOrDefault(e => e.Name == dept.ToLower());
                if (department == null)
                {
                    department = new Department();
                    department.Name = dept;
                    department.DepartmentId = deptId;
                    department.ListOfEmployees.Add(employee);
                    context.Departments.Add(department);
                }
                else
                {
                    //context.Update(Department.L)
                    department.ListOfEmployees.Add(employee);
                    deptId = department.DepartmentId;
                }
                //id = department.DepartmentId;
                //return id;
            }
            return deptId;
        }
        public IEnumerable FetchEmployeesWithDepartmentName()
        {
            using var context = new ModelContext();
            var result = context.Employees.Join(context.Departments, e => e.DepartmentId, d => d.DepartmentId,
                (employee, department) => new
                {
                    ID = employee.EmployeeId,
                    Name = employee.FirstName + " " + employee.LastName,
                    Email = employee.Email,
                    Phonenumber = employee.PhoneNumber,
                    state = employee.State,
                    salary = employee.Salary,
                    hired = employee.HireDate,
                    Department = department.Name
                }).ToList();
            return result;
        }
        public IEnumerable RecordsGroupedByDept()
        {
            using var context = new ModelContext();
            var result = context.Employees.Join(context.Departments, e => e.DepartmentId, d => d.DepartmentId,
                (employee, department) => new
                {
                    ID = employee.EmployeeId,
                    Name = employee.FirstName + " " + employee.LastName,
                    Email = employee.Email,
                    Phonenumber = employee.PhoneNumber,
                    state = employee.State,
                    salary = employee.Salary,
                    hired = employee.HireDate,
                    Department = department.Name
                }).OrderBy(d => d.Department).ToList();
            return result;
        }
        public IEnumerable DepartmentsNotAssignedToEmployee()
        {
            using var context = new ModelContext();
            var result = context.Departments.Where(d => d.ListOfEmployees.Count == 0).ToList();
            return result;
        }

        public IEnumerable EmployeesWithSalaryBtw150kAnd300k()
        {
            using var context = new ModelContext();
            var result = context.Employees.Where(e => e.Salary >= 150000 & e.Salary <= 300000).ToList();
            return result;
        }

        public IEnumerable EmployeesAndDepartmentAssignedOrNotAssigned()
        {
            using var context = new ModelContext();
            var result = from d in context.Departments
                join e in context.Employees
                    on d.DepartmentId equals e.DepartmentId into emp
                from employee in emp.DefaultIfEmpty()
                select new
                {
                    DepartmentName = d.Name,
                    EmployeeID = employee == null ? "No employee assigned" : employee.EmployeeId,
                    EmployeeName = employee == null
                        ? "No employee assigned"
                        : employee.FirstName + " " + employee.LastName
                };
            return result.ToList();
        }

        public int AddDepartment(string deptName)
        {
            using var context = new ModelContext();
            var department = context.Departments.FirstOrDefault(d => d.Name == deptName.ToLower() && !string.IsNullOrEmpty(d.DepartmentId));
            if (department != null)
            {
                throw new Exception("This department already exists");
            }
            else
            {
                var dept = new Department()
                {
                    Name = deptName.ToLower(),
                    DepartmentId = Guid.NewGuid().ToString()
                };
                context.Departments.Add(dept);
               return  context.SaveChanges();
            }
        }

        public string FetchDepartmentId(string deptName)
        {
            string departmentID = "";
            using var context = new ModelContext();
            var department = context.Departments.FirstOrDefault(d => d.Name == deptName.ToLower());
            if (department== null)
            {
                throw new Exception("This Department does not exist, Consider viewing the existing departments");
            }
            else
            {
                departmentID = department.DepartmentId;
            }

            return departmentID;
        }

        public void CheckForDuplicateEmail(string email)
        {
            using var context = new ModelContext();
            var result = context.Employees.Any(e => e.Email == email);
            if (result)
            {
                throw new Exception("A user with this email address already exists");
            }
        }

        public IEnumerable ViewDepartments()
        {
            using var context = new ModelContext();
            var result = from d in context.Departments
                select new
                {
                    Name = d.Name,
                    ID = d.DepartmentId
                };
           return  result.ToList();
        }
    }
}
