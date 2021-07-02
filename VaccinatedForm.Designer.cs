
namespace Covitrack
{
    partial class Vaccinated_Form
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
            this.labelemployeeid = new System.Windows.Forms.Label();
            this.textBoxemployeeid = new System.Windows.Forms.TextBox();
            this.labelvaccinetype = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelVaccineDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBoxcertificate = new System.Windows.Forms.TextBox();
            this.labelcertificate = new System.Windows.Forms.Label();
            this.textBoxlocation = new System.Windows.Forms.TextBox();
            this.labeldose = new System.Windows.Forms.Label();
            this.labellocation = new System.Windows.Forms.Label();
            this.comboBoxdose = new System.Windows.Forms.ComboBox();
            this.comboBoxvaccinetype = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelemployeeid
            // 
            this.labelemployeeid.AutoSize = true;
            this.labelemployeeid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelemployeeid.Location = new System.Drawing.Point(242, 87);
            this.labelemployeeid.Name = "labelemployeeid";
            this.labelemployeeid.Size = new System.Drawing.Size(111, 16);
            this.labelemployeeid.TabIndex = 0;
            this.labelemployeeid.Text = "Employee Code:";
            // 
            // textBoxemployeeid
            // 
            this.textBoxemployeeid.Location = new System.Drawing.Point(354, 85);
            this.textBoxemployeeid.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxemployeeid.Name = "textBoxemployeeid";
            this.textBoxemployeeid.Size = new System.Drawing.Size(180, 23);
            this.textBoxemployeeid.TabIndex = 1;
            // 
            // labelvaccinetype
            // 
            this.labelvaccinetype.AutoSize = true;
            this.labelvaccinetype.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvaccinetype.Location = new System.Drawing.Point(242, 140);
            this.labelvaccinetype.Name = "labelvaccinetype";
            this.labelvaccinetype.Size = new System.Drawing.Size(95, 16);
            this.labelvaccinetype.TabIndex = 2;
            this.labelvaccinetype.Text = "Vaccine Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelVaccineDate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.textBoxcertificate);
            this.panel1.Controls.Add(this.labelcertificate);
            this.panel1.Controls.Add(this.textBoxlocation);
            this.panel1.Controls.Add(this.labeldose);
            this.panel1.Controls.Add(this.labellocation);
            this.panel1.Controls.Add(this.comboBoxdose);
            this.panel1.Controls.Add(this.comboBoxvaccinetype);
            this.panel1.Location = new System.Drawing.Point(225, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 401);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "\"dd-mm-yyyy\"";
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 195);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(180, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelVaccineDate
            // 
            this.labelVaccineDate.AutoSize = true;
            this.labelVaccineDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVaccineDate.Location = new System.Drawing.Point(17, 200);
            this.labelVaccineDate.Name = "labelVaccineDate";
            this.labelVaccineDate.Size = new System.Drawing.Size(94, 16);
            this.labelVaccineDate.TabIndex = 14;
            this.labelVaccineDate.Text = "Vaccine Date:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(331, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(215, 370);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(81, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.Location = new System.Drawing.Point(421, 304);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.Location = new System.Drawing.Point(331, 304);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBoxcertificate
            // 
            this.textBoxcertificate.Location = new System.Drawing.Point(129, 302);
            this.textBoxcertificate.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxcertificate.Name = "textBoxcertificate";
            this.textBoxcertificate.Size = new System.Drawing.Size(180, 23);
            this.textBoxcertificate.TabIndex = 8;
            // 
            // labelcertificate
            // 
            this.labelcertificate.AutoSize = true;
            this.labelcertificate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcertificate.Location = new System.Drawing.Point(17, 304);
            this.labelcertificate.Name = "labelcertificate";
            this.labelcertificate.Size = new System.Drawing.Size(76, 16);
            this.labelcertificate.TabIndex = 7;
            this.labelcertificate.Text = "Certificate:";
            // 
            // textBoxlocation
            // 
            this.textBoxlocation.Location = new System.Drawing.Point(129, 240);
            this.textBoxlocation.MinimumSize = new System.Drawing.Size(180, 25);
            this.textBoxlocation.Name = "textBoxlocation";
            this.textBoxlocation.Size = new System.Drawing.Size(180, 23);
            this.textBoxlocation.TabIndex = 5;
            // 
            // labeldose
            // 
            this.labeldose.AutoSize = true;
            this.labeldose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldose.Location = new System.Drawing.Point(17, 158);
            this.labeldose.Name = "labeldose";
            this.labeldose.Size = new System.Drawing.Size(42, 16);
            this.labeldose.TabIndex = 5;
            this.labeldose.Text = "Dose:";
            // 
            // labellocation
            // 
            this.labellocation.AutoSize = true;
            this.labellocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellocation.Location = new System.Drawing.Point(17, 242);
            this.labellocation.Name = "labellocation";
            this.labellocation.Size = new System.Drawing.Size(66, 16);
            this.labellocation.TabIndex = 4;
            this.labellocation.Text = "Location:";
            // 
            // comboBoxdose
            // 
            this.comboBoxdose.FormattingEnabled = true;
            this.comboBoxdose.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxdose.Location = new System.Drawing.Point(129, 156);
            this.comboBoxdose.MinimumSize = new System.Drawing.Size(180, 0);
            this.comboBoxdose.Name = "comboBoxdose";
            this.comboBoxdose.Size = new System.Drawing.Size(180, 23);
            this.comboBoxdose.TabIndex = 6;
            // 
            // comboBoxvaccinetype
            // 
            this.comboBoxvaccinetype.FormattingEnabled = true;
            this.comboBoxvaccinetype.Items.AddRange(new object[] {
            "Covisheild",
            "Covaxin"});
            this.comboBoxvaccinetype.Location = new System.Drawing.Point(129, 101);
            this.comboBoxvaccinetype.MinimumSize = new System.Drawing.Size(180, 0);
            this.comboBoxvaccinetype.Name = "comboBoxvaccinetype";
            this.comboBoxvaccinetype.Size = new System.Drawing.Size(180, 23);
            this.comboBoxvaccinetype.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Vaccinated_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelvaccinetype);
            this.Controls.Add(this.textBoxemployeeid);
            this.Controls.Add(this.labelemployeeid);
            this.Controls.Add(this.panel1);
            this.Name = "Vaccinated_Form";
            this.Text = "Vaccinated_Form";
            this.Load += new System.EventHandler(this.Vaccinated_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelemployeeid;
        private System.Windows.Forms.TextBox textBoxemployeeid;
        private System.Windows.Forms.Label labelvaccinetype;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxcertificate;
        private System.Windows.Forms.Label labelcertificate;
        private System.Windows.Forms.TextBox textBoxlocation;
        private System.Windows.Forms.Label labeldose;
        private System.Windows.Forms.Label labellocation;
        private System.Windows.Forms.ComboBox comboBoxdose;
        private System.Windows.Forms.ComboBox comboBoxvaccinetype;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelVaccineDate;
    }
}