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
    public partial class VaccinatedDetails : Form
    {
        public VaccinatedDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VaccinatedDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchbox = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(searchbox);
            string SqlQuery = "select * from Vaccinated_Employee where emp_code = '" + textBoxsearch.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vaccinated_Employee ORDER BY emp_code", con);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
                
            }
        }

        private void VaccinatedDetails_Load_1(object sender, EventArgs e)
        {
            string load = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(load);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Vaccinated_Employee ORDER BY emp_code", con);

            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }
    }
    

}
