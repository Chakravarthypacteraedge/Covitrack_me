using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covitrack
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Dashboard f5 = new Dashboard();
            f5.ShowDialog();
        }
    }
}
