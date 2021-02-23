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
    public partial class Select_A_Product_Form : Form
    {
        public Select_A_Product_Form()
        {
            InitializeComponent();
        }

        private void Select_A_Product_Form_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Opens up a Create or View form and sets the product name to "DEV"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProductDEV_Click(object sender, EventArgs e)
        {
            Globals.Product = Globals.ProductType.Dev;
            OpenCoVForm();
        }

        private void buttonProductPH2_Click(object sender, EventArgs e)
        {
        }

        private void buttonProductVplay_Click(object sender, EventArgs e)
        {
            Globals.Product = Globals.ProductType.Vplay;
            OpenCoVForm();
        }

        private void OpenCoVForm()
        {
            var cov = new Create_Or_View();
            cov.Show();

            this.Hide();
        }
    }
}