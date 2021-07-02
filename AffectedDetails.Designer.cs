
namespace Covitrack
{
    partial class AffectedDetails
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.dataGridViewAffected = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAffected)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(481, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(256, 67);
            this.textBoxsearch.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.PlaceholderText = "Employee_id";
            this.textBoxsearch.Size = new System.Drawing.Size(180, 23);
            this.textBoxsearch.TabIndex = 11;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // dataGridViewAffected
            // 
            this.dataGridViewAffected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAffected.Location = new System.Drawing.Point(25, 108);
            this.dataGridViewAffected.Name = "dataGridViewAffected";
            this.dataGridViewAffected.RowTemplate.Height = 25;
            this.dataGridViewAffected.Size = new System.Drawing.Size(751, 332);
            this.dataGridViewAffected.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Affected Employee Details";
            // 
            // AffectedDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.dataGridViewAffected);
            this.Controls.Add(this.label1);
            this.Name = "AffectedDetails";
            this.Text = "AffectedDetails";
            this.Load += new System.EventHandler(this.AffectedDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAffected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.DataGridView dataGridViewAffected;
        private System.Windows.Forms.Label label1;
    }
}