namespace Music_Player
{
    partial class No_Talk
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPlaying = new System.Windows.Forms.TextBox();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btn_Play = new System.Windows.Forms.Button();
			this.btn_Random = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBack);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbPlaying);
			this.groupBox1.Controls.Add(this.btn_Stop);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.btn_Play);
			this.groupBox1.Controls.Add(this.btn_Random);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Location = new System.Drawing.Point(9, 9);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(282, 290);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "List of no talking ASMR";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 268);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Playing:";
			// 
			// tbPlaying
			// 
			this.tbPlaying.Location = new System.Drawing.Point(55, 265);
			this.tbPlaying.Name = "tbPlaying";
			this.tbPlaying.ReadOnly = true;
			this.tbPlaying.Size = new System.Drawing.Size(165, 20);
			this.tbPlaying.TabIndex = 5;
			// 
			// btn_Stop
			// 
			this.btn_Stop.Location = new System.Drawing.Point(225, 231);
			this.btn_Stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Stop.Name = "btn_Stop";
			this.btn_Stop.Size = new System.Drawing.Size(53, 24);
			this.btn_Stop.TabIndex = 3;
			this.btn_Stop.Text = "Stop";
			this.btn_Stop.UseVisualStyleBackColor = true;
			this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(4, 17);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(217, 238);
			this.listBox1.TabIndex = 2;
			// 
			// btn_Play
			// 
			this.btn_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Play.Location = new System.Drawing.Point(225, 175);
			this.btn_Play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Play.Name = "btn_Play";
			this.btn_Play.Size = new System.Drawing.Size(53, 24);
			this.btn_Play.TabIndex = 1;
			this.btn_Play.Text = "Play";
			this.btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Play.UseVisualStyleBackColor = true;
			this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
			// 
			// btn_Random
			// 
			this.btn_Random.Location = new System.Drawing.Point(225, 203);
			this.btn_Random.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Random.Name = "btn_Random";
			this.btn_Random.Size = new System.Drawing.Size(53, 24);
			this.btn_Random.TabIndex = 0;
			this.btn_Random.Text = "Random";
			this.btn_Random.UseVisualStyleBackColor = true;
			this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(226, 258);
			this.btnBack.Margin = new System.Windows.Forms.Padding(2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(53, 24);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// No_Talk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 325);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "No_Talk";
			this.Text = "No talking ASMR";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlaying;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Random;
		private System.Windows.Forms.Button btnBack;
	}
}