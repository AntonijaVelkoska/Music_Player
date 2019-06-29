namespace Music_Player
{
    partial class Background_Music_Player
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
			this.btn_Mute = new System.Windows.Forms.Button();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btn_Play = new System.Windows.Forms.Button();
			this.btn_Random = new System.Windows.Forms.Button();
			this.tbPlaying = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbPlaying);
			this.groupBox1.Controls.Add(this.btn_Mute);
			this.groupBox1.Controls.Add(this.btn_Stop);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.btn_Play);
			this.groupBox1.Controls.Add(this.btn_Random);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Location = new System.Drawing.Point(14, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(282, 290);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "List of Background music";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btn_Mute
			// 
			this.btn_Mute.Location = new System.Drawing.Point(225, 243);
			this.btn_Mute.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Mute.Name = "btn_Mute";
			this.btn_Mute.Size = new System.Drawing.Size(53, 24);
			this.btn_Mute.TabIndex = 4;
			this.btn_Mute.Text = "Mute";
			this.btn_Mute.UseVisualStyleBackColor = true;
			this.btn_Mute.Click += new System.EventHandler(this.btn_Mute_Click);
			// 
			// btn_Stop
			// 
			this.btn_Stop.Location = new System.Drawing.Point(225, 215);
			this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
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
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(217, 238);
			this.listBox1.TabIndex = 2;
			// 
			// btn_Play
			// 
			this.btn_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Play.Location = new System.Drawing.Point(225, 159);
			this.btn_Play.Margin = new System.Windows.Forms.Padding(2);
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
			this.btn_Random.Location = new System.Drawing.Point(225, 187);
			this.btn_Random.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Random.Name = "btn_Random";
			this.btn_Random.Size = new System.Drawing.Size(53, 24);
			this.btn_Random.TabIndex = 0;
			this.btn_Random.Text = "Random";
			this.btn_Random.UseVisualStyleBackColor = true;
			this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
			// 
			// tbPlaying
			// 
			this.tbPlaying.Location = new System.Drawing.Point(55, 265);
			this.tbPlaying.Name = "tbPlaying";
			this.tbPlaying.ReadOnly = true;
			this.tbPlaying.Size = new System.Drawing.Size(165, 20);
			this.tbPlaying.TabIndex = 5;
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
			// Background_Music_Player
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 316);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Background_Music_Player";
			this.Text = "Background Music Player";
			this.Load += new System.EventHandler(this.Background_Music_Player_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Mute;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Random;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPlaying;
	}
}