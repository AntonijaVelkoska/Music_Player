﻿namespace Music_Player
{
    partial class ASMR_Choice
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Talking = new System.Windows.Forms.Button();
			this.btn_no_talking = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(168, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Pick the type of ASMR";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Talking
			// 
			this.btn_Talking.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Talking.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btn_Talking.Location = new System.Drawing.Point(13, 101);
			this.btn_Talking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Talking.Name = "btn_Talking";
			this.btn_Talking.Size = new System.Drawing.Size(128, 36);
			this.btn_Talking.TabIndex = 7;
			this.btn_Talking.Text = "Talking ASMR";
			this.btn_Talking.UseVisualStyleBackColor = true;
			this.btn_Talking.Click += new System.EventHandler(this.btn_Talking_Click);
			// 
			// btn_no_talking
			// 
			this.btn_no_talking.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_no_talking.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btn_no_talking.Location = new System.Drawing.Point(13, 48);
			this.btn_no_talking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_no_talking.Name = "btn_no_talking";
			this.btn_no_talking.Size = new System.Drawing.Size(128, 36);
			this.btn_no_talking.TabIndex = 6;
			this.btn_no_talking.Text = "No Talking ASMR";
			this.btn_no_talking.UseVisualStyleBackColor = true;
			this.btn_no_talking.Click += new System.EventHandler(this.btn_no_talking_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnBack.Location = new System.Drawing.Point(193, 101);
			this.btnBack.Margin = new System.Windows.Forms.Padding(2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(128, 36);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// ASMR_Choice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 155);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Talking);
			this.Controls.Add(this.btn_no_talking);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ASMR_Choice";
			this.Text = "Choice for ASMR";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Talking;
        private System.Windows.Forms.Button btn_no_talking;
		private System.Windows.Forms.Button btnBack;
	}
}