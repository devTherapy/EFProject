using EfProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace EFProject.UI
{
    public partial class FetchPage : Form
    {
        private IRepository repository;
        
        public FetchPage(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView1.DataSource = repository.EmployeesWithSalaryBtw150kAnd300k();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void FetchAllEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var result = repository.FetchEmployeesWithDepartmentName();
                dataGridView1.DataSource = result;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FetchPage_Load(object sender, EventArgs e)
        {

        }

        private void GPByDept_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
             dataGridView1.DataSource =   repository.RecordsGroupedByDept();
            }
            catch (Exception exception)
            {
                 MessageBox.Show(exception.Message);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mainform = new Form1(repository);
            this.Close();
            mainform.Show();
        }

        private void unassignedDepts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
               dataGridView1.DataSource = repository.DepartmentsNotAssignedToEmployee();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AllEmpsandDepts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView1.DataSource = repository.EmployeesAndDepartmentAssignedOrNotAssigned();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
