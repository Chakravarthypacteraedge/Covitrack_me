using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace Covitrack
{
    public partial class Vaccinated_Form : Form
    {
        public Vaccinated_Form()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog vaccine = new OpenFileDialog();
            vaccine.Title = "Select file to Upload";
            vaccine.InitialDirectory = @"";
            vaccine.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            
            vaccine.RestoreDirectory = true;
            if (vaccine.ShowDialog() == DialogResult.OK)
            {
                textBoxcertificate.Text = Path.GetFileName(vaccine.FileName);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            string Filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (Filename == null)
            {
                MessageBox.Show("Please select a valid document.");
            }
            else
            {
                MessageBox.Show("File Uploaded");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.CustomFormat = "dd-mm-yyyy";
        }

        private void Vaccinated_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (Filename == null)
            {
                MessageBox.Show("Please select a valid document.");
            }
            if (string.IsNullOrEmpty(this.textBoxemployeeid.Text) || string.IsNullOrEmpty(this.textBoxlocation.Text) || (dateTimePicker1.Visible == false) || string.IsNullOrEmpty(this.textBoxcertificate.Text))
            {
                MessageBox.Show("Complete All your Details");
            }
            else
            {
                string submit = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(submit);
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertVaccinated", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_code", textBoxemployeeid.Text);
                cmd.Parameters.AddWithValue("@Vaccine_Type", comboBoxvaccinetype.SelectedItem);
                cmd.Parameters.AddWithValue("@Dose_No", comboBoxdose.SelectedItem);
                cmd.Parameters.AddWithValue("@Vaccine_Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Vaccine_Location", textBoxlocation.Text);
                cmd.Parameters.AddWithValue("@Vaccine_Certificate", textBoxcertificate.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                con.Close();
                textBoxemployeeid.Clear();
                comboBoxvaccinetype.SelectedItem = null;
                comboBoxdose.SelectedItem = null;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
                textBoxlocation.Clear();
                textBoxcertificate.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(update);
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateVaccinated", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_code", textBoxemployeeid.Text);
            cmd.Parameters.AddWithValue("@Vaccine_Type", comboBoxvaccinetype.SelectedItem);
            cmd.Parameters.AddWithValue("@Dose_No", comboBoxdose.SelectedItem);
            cmd.Parameters.AddWithValue("@Vaccine_Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Vaccine_Location", textBoxlocation.Text);
            cmd.Parameters.AddWithValue("@Vaccine_Certificate", textBoxcertificate.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            con.Close();

        }
    }
}
