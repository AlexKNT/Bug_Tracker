
namespace Bug_Tracker.Forms
{
    partial class Create_Or_View
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
            this.buttonCoVView = new System.Windows.Forms.Button();
            this.buttonCoVCreate = new System.Windows.Forms.Button();
            this.buttonBackCreateOrView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCoVView
            // 
            this.buttonCoVView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonCoVView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCoVView.ForeColor = System.Drawing.Color.Black;
            this.buttonCoVView.Location = new System.Drawing.Point(12, 49);
            this.buttonCoVView.Name = "buttonCoVView";
            this.buttonCoVView.Size = new System.Drawing.Size(215, 170);
            this.buttonCoVView.TabIndex = 1;
            this.buttonCoVView.Text = "View";
            this.buttonCoVView.UseVisualStyleBackColor = false;
            this.buttonCoVView.Click += new System.EventHandler(this.buttonCoVView_Click);
            // 
            // buttonCoVCreate
            // 
            this.buttonCoVCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCoVCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCoVCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCoVCreate.Location = new System.Drawing.Point(233, 49);
            this.buttonCoVCreate.Name = "buttonCoVCreate";
            this.buttonCoVCreate.Size = new System.Drawing.Size(215, 170);
            this.buttonCoVCreate.TabIndex = 1;
            this.buttonCoVCreate.Text = "Create";
            this.buttonCoVCreate.UseVisualStyleBackColor = false;
            this.buttonCoVCreate.Click += new System.EventHandler(this.buttonCoVCreate_Click);
            // 
            // buttonBackCreateOrView
            // 
            this.buttonBackCreateOrView.BackColor = System.Drawing.Color.Maroon;
            this.buttonBackCreateOrView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackCreateOrView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackCreateOrView.Location = new System.Drawing.Point(12, 12);
            this.buttonBackCreateOrView.Name = "buttonBackCreateOrView";
            this.buttonBackCreateOrView.Size = new System.Drawing.Size(31, 31);
            this.buttonBackCreateOrView.TabIndex = 2;
            this.buttonBackCreateOrView.Text = "<--";
            this.buttonBackCreateOrView.UseVisualStyleBackColor = false;
            this.buttonBackCreateOrView.Click += new System.EventHandler(this.buttonBackCreateOrView_Click_1);
            // 
            // Create_Or_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 231);
            this.Controls.Add(this.buttonBackCreateOrView);
            this.Controls.Add(this.buttonCoVCreate);
            this.Controls.Add(this.buttonCoVView);
            this.Name = "Create_Or_View";
            this.Text = "Create_Or_View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCoVView;
        private System.Windows.Forms.Button buttonCoVCreate;
        private System.Windows.Forms.Button buttonBackCreateOrView;
    }
}