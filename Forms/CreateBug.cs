using Bug_Tracker.ClassLib;
using Bug_Tracker.ClassLib.Access.SQL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Bug_Tracker.Forms
{
    public partial class CreateBug : Form
    {
        public CreateBug()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Creates a Model of a bug based on what the user input into the forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCBCreate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var model = new ModelBug
                {
                    BugProductName = Globals.Product.ToString(),
                    BugDescription = textBoxCreateBugDescription.Text,
                    BugText = textBoxCreateBugText.Text,
                    BugReportedVersion = comboBoxCreateBug.Text,
                    BugWhenReported = DateTime.Now,
                    BugFixed = false
                };

                var da = new DataAccess();

                try
                {
                    da.CreateBug(model);
                }
                catch
                {
                    Console.WriteLine("what the fuck bro");
                }

                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            textBoxCreateBugDescription.Text = "";
            textBoxCreateBugText.Text = "";
        }

        /// <summary>
        /// Helper method. Checks whether the text boxes in the form are filled or not
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = false;

            string[] textboxes = { textBoxCreateBugDescription.Text, textBoxCreateBugText.Text, comboBoxCreateBug.Text };

            // Uses LINQ and lambdas
            if (textboxes.All(x => !string.IsNullOrEmpty(x)))
            {
                output = true;
            }

            return output;
        }

        /// <summary>
        /// Makes the text placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCBDescription_Enter(object sender, EventArgs e)
        {
            if (textBoxCreateBugDescription.Text == "Description")
            {
                textBoxCreateBugDescription.Text = "";
            }
        }

        private void textBoxCBDescription_Leave(object sender, EventArgs e)
        {
            if (textBoxCreateBugDescription.Text == "")
            {
                textBoxCreateBugDescription.Text = "Description";
            }
        }

        private void textBoxCBDescriptionFull_Enter(object sender, EventArgs e)
        {
            if (textBoxCreateBugText.Text == "Full description of the problem goes here")
            {
                textBoxCreateBugText.Text = "";
            }
        }

        private void textBoxCBDescriptionFull_Leave(object sender, EventArgs e)
        {
            if (textBoxCreateBugText.Text == "")
            {
                textBoxCreateBugText.Text = "Full description of the problem goes here";
            }
        }

        private void CreateBug_Load(object sender, EventArgs e)
        {
            PopulateCBox(Globals.Product);
        }

        private void PopulateCBox(Globals.ProductType type)
        {
            if (!Globals.productVersions.ContainsKey(type))
            {
                throw new Exception("Bruh, how");
            }

            foreach (string version in Globals.productVersions[type])
            {
                comboBoxCreateBug.Items.Add(version);
            }
        }

        private void comboBoxCreateBug_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonBackCreateBug_Click(object sender, EventArgs e)
        {
            var cov = new Create_Or_View();
            cov.Show();

            this.Close();
        }
    }
}