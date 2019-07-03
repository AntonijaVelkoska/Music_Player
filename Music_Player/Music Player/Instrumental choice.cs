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
    public partial class Instrumental : Form
    {
        public Instrumental()
        {
            InitializeComponent();
        }

        private void btn_Classical_Click(object sender, EventArgs e)
        {
            Classical_Music classical = new Classical_Music();
            this.Visible = false;
            classical.ShowDialog();
            this.Close();
        }

        private void btn_Regular_Click(object sender, EventArgs e)
        {
            Modern_music modern = new Modern_music();
            this.Visible = false;
            modern.ShowDialog();
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
