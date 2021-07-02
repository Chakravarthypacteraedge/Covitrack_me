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
    public partial class AffectedDetails : Form
    {
        public AffectedDetails()
        {
            InitializeComponent();
        }

        private void AffectedDetails_Load(object sender, EventArgs e)
        {
            string load = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(load);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Affected_Employee ORDER BY emp_code", con);

            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewAffected.DataSource = dt;


            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchbox = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(searchbox);
            string SqlQuery = "select * from Affected_Employee where emp_code = '" + textBoxsearch.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewAffected.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No such Record");

            }


            con.Close();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxsearch.Text.Length == 0)
            {
                string back = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(back);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Affected_Employee ORDER BY emp_code", con);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridViewAffected.DataSource = dt;


                con.Close();
                
            }
        
        }
     
    }
}
