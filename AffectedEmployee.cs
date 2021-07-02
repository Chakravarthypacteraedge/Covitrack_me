using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Covitrack
{
    public partial class AffectedEmployee : Form
    {
        public AffectedEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxemployeeid.Text) || string.IsNullOrEmpty(this.textBoxrecovery.Text) || (this.radioBtnYes.Checked=false) || (this.radioBtnNo.Checked = false))
            {
                MessageBox.Show("Complete All your Details");
            }
            else
            {
                string submit = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(submit);
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertAffected", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp_code", textBoxemployeeid.Text);
                cmd.Parameters.AddWithValue("@Recovery_Duration", textBoxrecovery.Text);
           
                if (radioBtnYes.Checked)
                {
                    cmd.Parameters.AddWithValue("@Family_Members_Affected", "Yes");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Family_Members_Affected", "No");
                }
                
                cmd.Parameters.AddWithValue("@Family_Members_Relation", textBoxrelation.Text);
                cmd.Parameters.AddWithValue("@Family_Members_Name", textBoxrelationname.Text);

                int i = cmd.ExecuteNonQuery();

                con.Close();
                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }
                textBoxemployeeid.Clear();
                textBoxrecovery.Clear();
                radioBtnYes.Checked = false;
                radioBtnNo.Checked = false;
                textBoxrelation.Clear();
                textBoxrelationname.Clear();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(update);
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateAffected", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_code", textBoxemployeeid.Text);
            cmd.Parameters.AddWithValue("@Recovery_Duration", textBoxrecovery.Text);
            if (radioBtnYes.Checked)
            {
                cmd.Parameters.AddWithValue("@Family_Members_Affected", "Yes");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Family_Members_Affected", "No");
            }

            cmd.Parameters.AddWithValue("@Family_Members_Relation", textBoxrelation.Text);
            cmd.Parameters.AddWithValue("@Family_Members_Name", textBoxrelationname.Text);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
