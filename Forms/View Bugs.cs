using Bug_Tracker.ClassLib;
using Bug_Tracker.ClassLib.Access.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker.Forms
{
    public partial class View_Bugs : Form
    {
        private List<ModelBug> bugs = new List<ModelBug>();

        public View_Bugs()
        {
            InitializeComponent();

            dataGridViewVB.DataSource = bugs;
        }

        private void View_Bugs_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewVB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonVBView_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            bugs = db.GetBugs(Globals.Product.ToString());

            dataGridViewVB.DataSource = bugs;
        }

        private void buttonBackViewBugs_Click(object sender, EventArgs e)
        {
            var cov = new Create_Or_View();
            cov.Show();

            this.Close();
        }
    }
}