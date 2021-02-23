
namespace Bug_Tracker.Forms
{
    partial class View_Bugs
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
            this.buttonVBView = new System.Windows.Forms.Button();
            this.dataGridViewVB = new System.Windows.Forms.DataGridView();
            this.buttonBackViewBugs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVBView
            // 
            this.buttonVBView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonVBView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVBView.ForeColor = System.Drawing.Color.Black;
            this.buttonVBView.Location = new System.Drawing.Point(352, 428);
            this.buttonVBView.Name = "buttonVBView";
            this.buttonVBView.Size = new System.Drawing.Size(113, 51);
            this.buttonVBView.TabIndex = 3;
            this.buttonVBView.Text = "View";
            this.buttonVBView.UseVisualStyleBackColor = false;
            this.buttonVBView.Click += new System.EventHandler(this.buttonVBView_Click);
            // 
            // dataGridViewVB
            // 
            this.dataGridViewVB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVB.Location = new System.Drawing.Point(23, 53);
            this.dataGridViewVB.Name = "dataGridViewVB";
            this.dataGridViewVB.Size = new System.Drawing.Size(776, 369);
            this.dataGridViewVB.TabIndex = 7;
            this.dataGridViewVB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVB_CellContentClick);
            // 
            // buttonBackViewBugs
            // 
            this.buttonBackViewBugs.BackColor = System.Drawing.Color.Maroon;
            this.buttonBackViewBugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackViewBugs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackViewBugs.Location = new System.Drawing.Point(23, 12);
            this.buttonBackViewBugs.Name = "buttonBackViewBugs";
            this.buttonBackViewBugs.Size = new System.Drawing.Size(31, 31);
            this.buttonBackViewBugs.TabIndex = 8;
            this.buttonBackViewBugs.Text = "<--";
            this.buttonBackViewBugs.UseVisualStyleBackColor = false;
            this.buttonBackViewBugs.Click += new System.EventHandler(this.buttonBackViewBugs_Click);
            // 
            // View_Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.buttonBackViewBugs);
            this.Controls.Add(this.dataGridViewVB);
            this.Controls.Add(this.buttonVBView);
            this.Name = "View_Bugs";
            this.Text = "View_Bugs";
            this.Load += new System.EventHandler(this.View_Bugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVBView;
        private System.Windows.Forms.DataGridView dataGridViewVB;
        private System.Windows.Forms.Button buttonBackViewBugs;
    }
}