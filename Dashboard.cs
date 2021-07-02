using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Covitrack
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void vaccinatedEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vaccinated_Form f2 = new Vaccinated_Form();
            f2.ShowDialog();
        }

        private void affectedEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffectedEmployee f3 = new AffectedEmployee();
            f3.ShowDialog();
        }


    }

}
