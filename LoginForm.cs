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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string log = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(log);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LoginDetails WHERE emp_code='" + textBoxemployeeid.Text + "' AND Password='" + textBoxpassword.Text + "'", con);
            
            EmployeeDetails f2 = new EmployeeDetails();
            this.Hide();
            f2.ShowDialog();
            this.Close();
           
            con.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
