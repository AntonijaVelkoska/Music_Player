using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Music_Player
{
    public partial class Classical_Music : Form
    {
        SoundPlayer player;
        Random random;
        public Classical_Music()
        {
            InitializeComponent();
        }

        private void Classical_Music_Load(object sender, EventArgs e)
        {
            string[] songs = Directory.GetFiles(@"C:\Users\Robert\Downloads", "*.wav", SearchOption.TopDirectoryOnly);
            //TODO: da se smeni so tocniot folder
            foreach (string i in songs)
            {
                listBox1.Items.Add(new Song(i));
            }
            player = new SoundPlayer();
            random = new Random();

        }
        private void btn_Play_Click(object sender, EventArgs e)
        {
            var song = listBox1.SelectedItem as Song;
            song.Play(player);
            tbPlaying.Text = song.ToString();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
            tbPlaying.Text = "";
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            int index = random.Next(listBox1.Items.Count - 1);
            var song = listBox1.Items[index] as Song;
            song.Play(player);
            tbPlaying.Text = song.ToString();
        }

		private void btnBack_Click(object sender, EventArgs e)
		{
			player.Stop();
			tbPlaying.Text = "";
			Form1 form1 = new Form1();
			this.Visible = false;
			form1.ShowDialog();
			this.Close();
		}
	}
}
