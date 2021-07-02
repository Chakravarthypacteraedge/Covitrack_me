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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchbox = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(searchbox);
            string SqlQuery = "select * from Employee_Data where emp_code = '" + textBoxsearch.Text + "'";
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

        private void Form1_Load(object sender, EventArgs e)
        {

            string load = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(load);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Data ORDER BY id", con);
           
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxsearch.Text.Length == 0)
            {
                string back = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(back);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Data ORDER BY id", con);

                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();
            }
        }

        private void vaccinatedEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaccinatedDetails f3 = new VaccinatedDetails();
            f3.ShowDialog();
        }

        private void affectedEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffectedDetails f4 = new AffectedDetails();
            f4.ShowDialog();
        }
    }
}
