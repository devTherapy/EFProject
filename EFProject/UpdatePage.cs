using EfProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EFProject.Commons;
using EFProject.Models;

namespace EFProject.UI
{
    public partial class UpdatePage : Form
    {
        private IRepository repository;

        
        public UpdatePage(IRepository repository)
        {
            InitializeComponent();

            this.repository = repository;
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            var mainform = new Form1(repository);
            this.Close();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeId = textBox1.Text;
            var firstName = FirstNametxt.Text;
            var lastName = LastNametxt.Text;
            var email = Emailtxt.Text;
            var phoneNumber = PhoneNumbertxt.Text;
            var state = Statetxt.Text;
            var department = DepartmentID.Text;
            var salary = Salarytxt.Text;

            try
            {
               
               var employee = repository.FindEmployeeByID(employeeId);
               var newDeptId = "";
               if (!String.IsNullOrEmpty(department))
               {
                    newDeptId = repository.FetchDepartmentId(department);
               }
                double numericSalary = 0;
               if (!String.IsNullOrEmpty(salary))
               {
                   Utilities.ValidateSalary(salary, out numericSalary);
               }
              
               var inputParameters = new[]
               {
                   String.IsNullOrEmpty(firstName) ? employee.FirstName : firstName,
                   String.IsNullOrEmpty(lastName) ? employee.LastName : lastName,
                   String.IsNullOrEmpty(email) ? employee.Email : email,
                   String.IsNullOrEmpty(phoneNumber) ? employee.PhoneNumber : phoneNumber,
                   String.IsNullOrEmpty(state) ? employee.State : state,
                   String.IsNullOrEmpty(department) ? employee.DepartmentId : newDeptId

               };
               var employeeSalary = String.IsNullOrEmpty(salary) ? employee.Salary : numericSalary;

              int rows = repository.UpdateEmployee(employee, employeeSalary, inputParameters);
              if (rows >= 1)
              {
                  MessageBox.Show("Update Successful");
              }
              else
              {
                  MessageBox.Show("Error updating details");
              }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Statetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
