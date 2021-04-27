using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EFProject.Models;

namespace EfProject.Core
{
    public interface IRepository
    {
        /// <summary>
        /// Adds an employee to the databse.
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="properties"></param>
        /// <returns>returns the number of rows affected </returns>
        int AddEmployee(double salary, params string[] properties);
        /// <summary>
        /// deletes an emloyee from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>the number of rows affected</returns>
        int DeleteEmployee(string ID);
        /// <summary>
        /// finds an employee in the database by their ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Employee FindEmployeeByID(string ID);
        /// <summary>
        /// Updates an employee in the database
        /// </summary>
        /// <param name="Employee"></param>
        /// <param name="salary"></param>
        /// <param name="properties"></param>
        /// <returns>the number of rows affected</returns>
        int UpdateEmployee(Employee Employee, double salary, params string[]properties );
        string AddEmployeeToDepartment(Employee employee, string dept);
        
        IEnumerable FetchEmployeesWithDepartmentName();
        /// <summary>
        /// Group records by department
        /// </summary>
        /// <returns></returns>
        IEnumerable RecordsGroupedByDept();
        /// <summary>
        /// Returns the departments not assigned to any employee
        /// </summary>
        /// <returns></returns>
        IEnumerable DepartmentsNotAssignedToEmployee();
        /// <summary>
        /// Returns employees with salaries between 150,000 - 300,000
        /// </summary>
        /// <returns></returns>
        IEnumerable EmployeesWithSalaryBtw150kAnd300k();
        /// <summary>
        /// Returns the designed or not assigned
        /// </summary>
        /// <returns></returns>
        IEnumerable EmployeesAndDepartmentAssignedOrNotAssigned();
        /// <summary>
        /// Adds a department to a database
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        int AddDepartment(string deptName);
        /// <summary>
        /// Fetches a department by the department ID
        /// </summary>
        /// <param name="deptName"></param>
        /// <returns></returns>
        string FetchDepartmentId(string deptName);
        /// <summary>
        /// Checks if an email already exists in the databse
        /// </summary>
        /// <param name="email"></param>
        void CheckForDuplicateEmail(string email);
        /// <summary>
        /// Views all the departments in the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable ViewDepartments();


    }
}