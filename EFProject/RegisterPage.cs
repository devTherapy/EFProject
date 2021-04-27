using EfProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EFProject.Commons;

namespace EFProject.UI
{
    public partial class RegisterPage : Form
    {
        private IRepository repository;

        
        public RegisterPage(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void LastNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = FirstNametxt.Text;
            var lastName = LastNametxt.Text;
            var email = Emailtxt.Text;
            var phoneNumber = PhoneNumbertxt.Text;
            var state = Statetxt.Text;
            var department = DepartmentID.Text;
            var salary = Salarytxt.Text;

            try
            {
                Utilities.ValidateName(firstName);
                Utilities.ValidateName(lastName);
                Utilities.ValidateEmail(email);
                Utilities.ValidatePhoneNumber(phoneNumber);
                Utilities.ValidateInput(state);
                Utilities.ValidateInput(department);
                //double numericSalary = 0;
                Utilities.ValidateSalary(salary, out double numericSalary);
                var inputParameters = new string[]
                {
                    firstName,
                    lastName,
                    email,
                    phoneNumber,
                    state,
                    department
                };
               int row =  repository.AddEmployee(numericSalary, inputParameters);
               if (row >= 1)
               {
                   MessageBox.Show("Registration successful");
               }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainform = new Form1(repository);
            this.Hide();
            mainform.Show();
        }
    }
}
