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
    public partial class Create_Or_View : Form
    {
        public Create_Or_View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens up a View Bugs form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCoVView_Click(object sender, EventArgs e)
        {
            ///
            var viewBugs = new View_Bugs();
            viewBugs.Show();

            this.Close();
        }

        /// <summary>
        /// Opens up a Create Bug form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCoVCreate_Click(object sender, EventArgs e)
        {
            var createBug = new CreateBug();
            createBug.Show();

            this.Close();
        }

        private void buttonBackCreateOrView_Click(object sender, EventArgs e)
        {
            // what
        }

        private void buttonBackCreateOrView_Click_1(object sender, EventArgs e)
        {
            var sap = new Select_A_Product_Form();
            sap.Show();

            this.Hide();
        }
    }
}