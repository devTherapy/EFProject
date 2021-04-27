
namespace EFProject.UI
{
    partial class FetchPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPBySalary = new System.Windows.Forms.LinkLabel();
            this.GPByDept = new System.Windows.Forms.LinkLabel();
            this.FetchAllEmp = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllEmpsandDepts = new System.Windows.Forms.LinkLabel();
            this.unassignedDepts = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBySalary
            // 
            this.GPBySalary.AutoSize = true;
            this.GPBySalary.BackColor = System.Drawing.Color.Wheat;
            this.GPBySalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GPBySalary.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPBySalary.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GPBySalary.LinkColor = System.Drawing.Color.DarkOrange;
            this.GPBySalary.Location = new System.Drawing.Point(16, 221);
            this.GPBySalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPBySalary.Name = "GPBySalary";
            this.GPBySalary.Size = new System.Drawing.Size(256, 33);
            this.GPBySalary.TabIndex = 4;
            this.GPBySalary.TabStop = true;
            this.GPBySalary.Text = "Salary: 150k-300k";
            this.GPBySalary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // GPByDept
            // 
            this.GPByDept.AutoSize = true;
            this.GPByDept.BackColor = System.Drawing.Color.Wheat;
            this.GPByDept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GPByDept.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPByDept.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GPByDept.LinkColor = System.Drawing.Color.DarkOrange;
            this.GPByDept.Location = new System.Drawing.Point(13, 102);
            this.GPByDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPByDept.Name = "GPByDept";
            this.GPByDept.Size = new System.Drawing.Size(307, 33);
            this.GPByDept.TabIndex = 2;
            this.GPByDept.TabStop = true;
            this.GPByDept.Text = "Group By Department";
            this.GPByDept.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GPByDept_LinkClicked);
            // 
            // FetchAllEmp
            // 
            this.FetchAllEmp.AutoSize = true;
            this.FetchAllEmp.BackColor = System.Drawing.Color.Wheat;
            this.FetchAllEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FetchAllEmp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FetchAllEmp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.FetchAllEmp.LinkColor = System.Drawing.Color.DarkOrange;
            this.FetchAllEmp.Location = new System.Drawing.Point(16, 18);
            this.FetchAllEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FetchAllEmp.Name = "FetchAllEmp";
            this.FetchAllEmp.Size = new System.Drawing.Size(208, 33);
            this.FetchAllEmp.TabIndex = 3;
            this.FetchAllEmp.TabStop = true;
            this.FetchAllEmp.Text = "All Employees";
            this.FetchAllEmp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FetchAllEmp_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.AllEmpsandDepts);
            this.panel1.Controls.Add(this.unassignedDepts);
            this.panel1.Controls.Add(this.FetchAllEmp);
            this.panel1.Controls.Add(this.GPBySalary);
            this.panel1.Controls.Add(this.GPByDept);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 782);
            this.panel1.TabIndex = 5;
            // 
            // AllEmpsandDepts
            // 
            this.AllEmpsandDepts.AutoSize = true;
            this.AllEmpsandDepts.BackColor = System.Drawing.Color.Wheat;
            this.AllEmpsandDepts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllEmpsandDepts.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllEmpsandDepts.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AllEmpsandDepts.LinkColor = System.Drawing.Color.DarkOrange;
            this.AllEmpsandDepts.Location = new System.Drawing.Point(13, 493);
            this.AllEmpsandDepts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllEmpsandDepts.Name = "AllEmpsandDepts";
            this.AllEmpsandDepts.Size = new System.Drawing.Size(446, 33);
            this.AllEmpsandDepts.TabIndex = 6;
            this.AllEmpsandDepts.TabStop = true;
            this.AllEmpsandDepts.Text = "All Employees and Departments";
            this.AllEmpsandDepts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllEmpsandDepts_LinkClicked);
            // 
            // unassignedDepts
            // 
            this.unassignedDepts.AutoSize = true;
            this.unassignedDepts.BackColor = System.Drawing.Color.Wheat;
            this.unassignedDepts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unassignedDepts.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unassignedDepts.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.unassignedDepts.LinkColor = System.Drawing.Color.DarkOrange;
            this.unassignedDepts.Location = new System.Drawing.Point(16, 342);
            this.unassignedDepts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unassignedDepts.Name = "unassignedDepts";
            this.unassignedDepts.Size = new System.Drawing.Size(353, 33);
            this.unassignedDepts.TabIndex = 5;
            this.unassignedDepts.TabStop = true;
            this.unassignedDepts.Text = "Unassigned Departments";
            this.unassignedDepts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.unassignedDepts_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Wheat;
            this.dataGridView1.Location = new System.Drawing.Point(478, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(759, 782);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1012, 676);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FetchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1237, 779);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FetchPage";
            this.Text = "FetchPage";
            this.Load += new System.EventHandler(this.FetchPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel GPBySalary;
        private System.Windows.Forms.LinkLabel GPByDept;
        private System.Windows.Forms.LinkLabel FetchAllEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel unassignedDepts;
        private System.Windows.Forms.LinkLabel AllEmpsandDepts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}