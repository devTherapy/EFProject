using EfProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.UI;

namespace EFProject
{
    public partial class Form1 : Form
    {
        private IRepository repository;
        public Form1(IRepository repository)
        {
            this.repository = repository;
            InitializeComponent();

        }

        private void AddEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var updatePage = new UpdatePage(repository);
            this.Hide();
            updatePage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerPage = new RegisterPage(repository);
            this.Hide();
            registerPage.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recordPage = new FetchPage(repository);
            this.Hide();
            recordPage.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var deletePage = new DeletePage(repository);
            this.Hide();
            deletePage.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var departmentPage = new AddDepartment(repository);
            this.Hide();
            departmentPage.Show();
        }
        
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                dataGridView1.DataSource = repository.ViewDepartments();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
