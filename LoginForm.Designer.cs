
namespace Covitrack
{
    partial class LoginForm
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
            this.textBoxemployeeid = new System.Windows.Forms.TextBox();
            this.labelemployeeid = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxemployeeid
            // 
            this.textBoxemployeeid.Location = new System.Drawing.Point(365, 112);
            this.textBoxemployeeid.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxemployeeid.Name = "textBoxemployeeid";
            this.textBoxemployeeid.Size = new System.Drawing.Size(180, 23);
            this.textBoxemployeeid.TabIndex = 3;
            // 
            // labelemployeeid
            // 
            this.labelemployeeid.AutoSize = true;
            this.labelemployeeid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelemployeeid.Location = new System.Drawing.Point(233, 114);
            this.labelemployeeid.Name = "labelemployeeid";
            this.labelemployeeid.Size = new System.Drawing.Size(111, 16);
            this.labelemployeeid.TabIndex = 2;
            this.labelemployeeid.Text = "Employee Code:";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(365, 182);
            this.textBoxpassword.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(180, 23);
            this.textBoxpassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(401, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 50);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome To PacteraEdge";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxemployeeid);
            this.Controls.Add(this.labelemployeeid);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxemployeeid;
        private System.Windows.Forms.Label labelemployeeid;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
    }
}