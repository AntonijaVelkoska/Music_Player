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
    public partial class Sleep_Music : Form
    {
        public Sleep_Music()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void Form2_Load(object sender, EventArgs e)
		{

		}

        private void btn_Asmr_Click(object sender, EventArgs e)
        {
            ASMR_Choice asmr = new ASMR_Choice();
            this.Visible = false;
            asmr.ShowDialog();
            this.Close();
        }

        private void btn_Instrumental_Click(object sender, EventArgs e)
        {
            Instrumental instrumental = new Instrumental();
            this.Visible = false;
            instrumental.ShowDialog();
            this.Close();
        }
    }
}
