using EfProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace EFProject.UI
{
    public partial class AddDepartment : Form
    {
        private IRepository repository;
        public AddDepartment(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deptText = departmentTxt.Text;
            try
            {
               int rows =  repository.AddDepartment(deptText);
               if (rows >= 1)
               {
                   MessageBox.Show(deptText + " department" + " added successfully");
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
