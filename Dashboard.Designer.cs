
namespace Covitrack
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vaccinatedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectedEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaccinatedEmployeesToolStripMenuItem,
            this.affectedEmployeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Employee";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vaccinatedEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectedEmployeeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

