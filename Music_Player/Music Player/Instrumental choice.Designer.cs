namespace Music_Player
{
    partial class Form6
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
            this.btn_Regular = new System.Windows.Forms.Button();
            this.btn_Classical = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(504, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pick the type of instrumental music you want to be played";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Regular
            // 
            this.btn_Regular.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Regular.Location = new System.Drawing.Point(17, 118);
            this.btn_Regular.Name = "btn_Regular";
            this.btn_Regular.Size = new System.Drawing.Size(170, 44);
            this.btn_Regular.TabIndex = 7;
            this.btn_Regular.Text = "Modern music";
            this.btn_Regular.UseVisualStyleBackColor = true;
            // 
            // btn_Classical
            // 
            this.btn_Classical.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Classical.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Classical.Location = new System.Drawing.Point(17, 54);
            this.btn_Classical.Name = "btn_Classical";
            this.btn_Classical.Size = new System.Drawing.Size(170, 44);
            this.btn_Classical.TabIndex = 6;
            this.btn_Classical.Text = "Classical music";
            this.btn_Classical.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Regular);
            this.Controls.Add(this.btn_Classical);
            this.Name = "Form6";
            this.Text = "Choices for Instrumental music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Regular;
        private System.Windows.Forms.Button btn_Classical;
    }
}