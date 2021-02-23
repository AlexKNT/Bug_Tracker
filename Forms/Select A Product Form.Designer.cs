
namespace Bug_Tracker.Forms
{
    partial class Select_A_Product_Form
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
            this.buttonProductVplay = new System.Windows.Forms.Button();
            this.buttonProductPH2 = new System.Windows.Forms.Button();
            this.buttonProductPH1 = new System.Windows.Forms.Button();
            this.buttonProductPH3 = new System.Windows.Forms.Button();
            this.buttonProductDEV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProductVplay
            // 
            this.buttonProductVplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonProductVplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductVplay.ForeColor = System.Drawing.Color.Black;
            this.buttonProductVplay.Location = new System.Drawing.Point(15, 35);
            this.buttonProductVplay.Name = "buttonProductVplay";
            this.buttonProductVplay.Size = new System.Drawing.Size(160, 92);
            this.buttonProductVplay.TabIndex = 0;
            this.buttonProductVplay.Text = "Vplay";
            this.buttonProductVplay.UseVisualStyleBackColor = false;
            this.buttonProductVplay.Click += new System.EventHandler(this.buttonProductVplay_Click);
            // 
            // buttonProductPH2
            // 
            this.buttonProductPH2.BackColor = System.Drawing.Color.SlateGray;
            this.buttonProductPH2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonProductPH2.Location = new System.Drawing.Point(347, 35);
            this.buttonProductPH2.Name = "buttonProductPH2";
            this.buttonProductPH2.Size = new System.Drawing.Size(160, 92);
            this.buttonProductPH2.TabIndex = 0;
            this.buttonProductPH2.Text = "Placeholder2";
            this.buttonProductPH2.UseVisualStyleBackColor = false;
            this.buttonProductPH2.Click += new System.EventHandler(this.buttonProductPH2_Click);
            // 
            // buttonProductPH1
            // 
            this.buttonProductPH1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProductPH1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonProductPH1.Location = new System.Drawing.Point(181, 35);
            this.buttonProductPH1.Name = "buttonProductPH1";
            this.buttonProductPH1.Size = new System.Drawing.Size(160, 92);
            this.buttonProductPH1.TabIndex = 0;
            this.buttonProductPH1.Text = "Placeholder1";
            this.buttonProductPH1.UseVisualStyleBackColor = false;
            // 
            // buttonProductPH3
            // 
            this.buttonProductPH3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonProductPH3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonProductPH3.Location = new System.Drawing.Point(513, 35);
            this.buttonProductPH3.Name = "buttonProductPH3";
            this.buttonProductPH3.Size = new System.Drawing.Size(160, 92);
            this.buttonProductPH3.TabIndex = 0;
            this.buttonProductPH3.Text = "Placeholder3";
            this.buttonProductPH3.UseVisualStyleBackColor = false;
            // 
            // buttonProductDEV
            // 
            this.buttonProductDEV.BackColor = System.Drawing.Color.Crimson;
            this.buttonProductDEV.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonProductDEV.Location = new System.Drawing.Point(15, 146);
            this.buttonProductDEV.Name = "buttonProductDEV";
            this.buttonProductDEV.Size = new System.Drawing.Size(658, 92);
            this.buttonProductDEV.TabIndex = 0;
            this.buttonProductDEV.Text = "Dev";
            this.buttonProductDEV.UseVisualStyleBackColor = false;
            this.buttonProductDEV.Click += new System.EventHandler(this.buttonProductDEV_Click);
            // 
            // Select_A_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 261);
            this.Controls.Add(this.buttonProductDEV);
            this.Controls.Add(this.buttonProductPH1);
            this.Controls.Add(this.buttonProductPH3);
            this.Controls.Add(this.buttonProductPH2);
            this.Controls.Add(this.buttonProductVplay);
            this.Name = "Select_A_Product_Form";
            this.Text = "Select A Product";
            this.Load += new System.EventHandler(this.Select_A_Product_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProductVplay;
        private System.Windows.Forms.Button buttonProductPH2;
        private System.Windows.Forms.Button buttonProductPH1;
        private System.Windows.Forms.Button buttonProductPH3;
        private System.Windows.Forms.Button buttonProductDEV;
    }
}