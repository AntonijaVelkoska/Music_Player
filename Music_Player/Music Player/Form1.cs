using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
		
		private void btn_Background_Click(object sender, EventArgs e)
		{
			Background_Music_Player backgrnd = new Background_Music_Player();
			this.Visible = false;
			backgrnd.ShowDialog();
			this.Close();
		}

		private void btn_Sleep_Click(object sender, EventArgs e)
		{
			Sleep_Music sleeping = new Sleep_Music();
			this.Visible = false;
			sleeping.ShowDialog();
			this.Close();
		}
	}
}
