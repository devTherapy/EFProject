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
    public partial class DeletePage : Form
    {
        private IRepository repository;

        public DeletePage()
        {
        }

        public DeletePage(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ID = IDtxt.Text;


            try
            {
                DialogResult dialog = MessageBox.Show("Are you sure", "Delete employee", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                  int rows =   repository.DeleteEmployee(ID);

                  if (rows >= 1)
                  {
                      MessageBox.Show("Employee deleted successfully");
                  }
                  else
                  {
                      MessageBox.Show("Delete operation failed");
                  }
                    
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
            this.Close();
            mainform.Show();
        }
    }
}
