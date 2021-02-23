
namespace Bug_Tracker.Forms
{
    partial class CreateBug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateBug = new System.Windows.Forms.Button();
            this.textBoxCreateBugDescription = new System.Windows.Forms.TextBox();
            this.textBoxCreateBugText = new System.Windows.Forms.TextBox();
            this.comboBoxCreateBug = new System.Windows.Forms.ComboBox();
            this.buttonBackCreateBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateBug
            // 
            this.buttonCreateBug.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateBug.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateBug.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateBug.Location = new System.Drawing.Point(339, 447);
            this.buttonCreateBug.Name = "buttonCreateBug";
            this.buttonCreateBug.Size = new System.Drawing.Size(113, 51);
            this.buttonCreateBug.TabIndex = 2;
            this.buttonCreateBug.Text = "Create";
            this.buttonCreateBug.UseVisualStyleBackColor = false;
            this.buttonCreateBug.Click += new System.EventHandler(this.buttonCBCreate_Click);
            // 
            // textBoxCreateBugDescription
            // 
            this.textBoxCreateBugDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxCreateBugDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCreateBugDescription.Location = new System.Drawing.Point(12, 57);
            this.textBoxCreateBugDescription.Name = "textBoxCreateBugDescription";
            this.textBoxCreateBugDescription.Size = new System.Drawing.Size(776, 27);
            this.textBoxCreateBugDescription.TabIndex = 3;
            this.textBoxCreateBugDescription.Text = "Description";
            this.textBoxCreateBugDescription.Enter += new System.EventHandler(this.textBoxCBDescription_Enter);
            this.textBoxCreateBugDescription.Leave += new System.EventHandler(this.textBoxCBDescription_Leave);
            // 
            // textBoxCreateBugText
            // 
            this.textBoxCreateBugText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxCreateBugText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCreateBugText.Location = new System.Drawing.Point(12, 117);
            this.textBoxCreateBugText.Multiline = true;
            this.textBoxCreateBugText.Name = "textBoxCreateBugText";
            this.textBoxCreateBugText.Size = new System.Drawing.Size(776, 323);
            this.textBoxCreateBugText.TabIndex = 4;
            this.textBoxCreateBugText.Text = "Full description of the problem goes here";
            this.textBoxCreateBugText.Enter += new System.EventHandler(this.textBoxCBDescriptionFull_Enter);
            this.textBoxCreateBugText.Leave += new System.EventHandler(this.textBoxCBDescriptionFull_Leave);
            // 
            // comboBoxCreateBug
            // 
            this.comboBoxCreateBug.FormattingEnabled = true;
            this.comboBoxCreateBug.Location = new System.Drawing.Point(12, 90);
            this.comboBoxCreateBug.Name = "comboBoxCreateBug";
            this.comboBoxCreateBug.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCreateBug.TabIndex = 6;
            this.comboBoxCreateBug.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreateBug_SelectedIndexChanged);
            // 
            // buttonBackCreateBug
            // 
            this.buttonBackCreateBug.BackColor = System.Drawing.Color.Maroon;
            this.buttonBackCreateBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackCreateBug.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackCreateBug.Location = new System.Drawing.Point(12, 12);
            this.buttonBackCreateBug.Name = "buttonBackCreateBug";
            this.buttonBackCreateBug.Size = new System.Drawing.Size(31, 31);
            this.buttonBackCreateBug.TabIndex = 7;
            this.buttonBackCreateBug.Text = "<--";
            this.buttonBackCreateBug.UseVisualStyleBackColor = false;
            this.buttonBackCreateBug.Click += new System.EventHandler(this.buttonBackCreateBug_Click);
            // 
            // CreateBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 510);
            this.Controls.Add(this.buttonBackCreateBug);
            this.Controls.Add(this.comboBoxCreateBug);
            this.Controls.Add(this.textBoxCreateBugText);
            this.Controls.Add(this.textBoxCreateBugDescription);
            this.Controls.Add(this.buttonCreateBug);
            this.Name = "CreateBug";
            this.Text = "CreateBug";
            this.Load += new System.EventHandler(this.CreateBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateBug;
        private System.Windows.Forms.TextBox textBoxCreateBugDescription;
        private System.Windows.Forms.TextBox textBoxCreateBugText;
        private System.Windows.Forms.ComboBox comboBoxCreateBug;
        private System.Windows.Forms.Button buttonBackCreateBug;
    }
}