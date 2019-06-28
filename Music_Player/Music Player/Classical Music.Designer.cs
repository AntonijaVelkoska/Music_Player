namespace Music_Player
{
    partial class Classical_Music
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Mute);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_Play);
            this.groupBox1.Controls.Add(this.btn_Random);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Classical music";
            // 
            // btn_Mute
            // 
            this.btn_Mute.Location = new System.Drawing.Point(205, 206);
            this.btn_Mute.Name = "btn_Mute";
            this.btn_Mute.Size = new System.Drawing.Size(71, 29);
            this.btn_Mute.TabIndex = 4;
            this.btn_Mute.Text = "Mute";
            this.btn_Mute.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(205, 171);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(71, 29);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 212);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Play
            // 
            this.btn_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Play.Location = new System.Drawing.Point(205, 101);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(71, 29);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play";
            this.btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Play.UseVisualStyleBackColor = true;
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(205, 136);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(71, 29);
            this.btn_Random.TabIndex = 0;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = true;
            // 
            // Classical_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "Classical_Music";
            this.Text = "Classical Music";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Mute;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Random;
    }
}