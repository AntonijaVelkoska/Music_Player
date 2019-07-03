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
    public partial class ASMR_Choice : Form
    {
        public ASMR_Choice()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Talking_Click(object sender, EventArgs e)
        {
			Talk talk = new Talk();
			this.Visible = false;
			talk.ShowDialog();
			this.Close();
		}

        private void btn_no_talking_Click(object sender, EventArgs e)
		{
			No_Talk no_talk = new No_Talk();
			this.Visible = false;
			no_talk.ShowDialog();
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Sleep_Music sleep_Music = new Sleep_Music();
			this.Visible = false;
			sleep_Music.ShowDialog();
			this.Close();
		}
	}
}
