
namespace Covitrack
{
    partial class EmployeeDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.labelemployeedetails = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.vaccinatedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectedEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(733, 334);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(550, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(325, 91);
            this.textBoxsearch.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.PlaceholderText = "Employee_id";
            this.textBoxsearch.Size = new System.Drawing.Size(180, 25);
            this.textBoxsearch.TabIndex = 5;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // labelemployeedetails
            // 
            this.labelemployeedetails.AutoSize = true;
            this.labelemployeedetails.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelemployeedetails.Location = new System.Drawing.Point(124, 92);
            this.labelemployeedetails.Name = "labelemployeedetails";
            this.labelemployeedetails.Size = new System.Drawing.Size(170, 22);
            this.labelemployeedetails.TabIndex = 8;
            this.labelemployeedetails.Text = "Employee Details";
            this.labelemployeedetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaccinatedEmployeesToolStripMenuItem,
            this.affectedEmployeeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // vaccinatedEmployeesToolStripMenuItem
            // 
            this.vaccinatedEmployeesToolStripMenuItem.Name = "vaccinatedEmployeesToolStripMenuItem";
            this.vaccinatedEmployeesToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.vaccinatedEmployeesToolStripMenuItem.Text = "Vaccinated Employees";
            this.vaccinatedEmployeesToolStripMenuItem.Click += new System.EventHandler(this.vaccinatedEmployeesToolStripMenuItem_Click);
            // 
            // affectedEmployeeToolStripMenuItem
            // 
            this.affectedEmployeeToolStripMenuItem.Name = "affectedEmployeeToolStripMenuItem";
            this.affectedEmployeeToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.affectedEmployeeToolStripMenuItem.Text = "Affected Employees";
            this.affectedEmployeeToolStripMenuItem.Click += new System.EventHandler(this.affectedEmployeeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.labelemployeedetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label labelemployeedetails;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem vaccinatedEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectedEmployeeToolStripMenuItem;
    }
}