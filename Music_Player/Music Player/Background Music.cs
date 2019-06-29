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
    public partial class Background_Music_Player : Form
    {
		SoundPlayer player;
		Random random;
        public Background_Music_Player()
        {
            InitializeComponent();
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Background_Music_Player_Load(object sender, EventArgs e)
		{
			string[] songs = Directory.GetFiles(@"D:\school shit\четврти семестар\вп\Project\Музика за проектот\Ambient aka Background", "*.wav", SearchOption.TopDirectoryOnly);
			//TODO: da se smeni so tocniot folder
			foreach(string i in songs)
			{
				listBox1.Items.Add(new Song(i));
			}
			player = new SoundPlayer();
			random = new Random();
		}

		private void btn_Play_Click(object sender, EventArgs e)
		{
				Play(listBox1.SelectedItem as Song);
		}

		private void btn_Stop_Click(object sender, EventArgs e)
		{
			player.Stop();
		}

		private void btn_Random_Click(object sender, EventArgs e)
		{
			int index = random.Next(listBox1.Items.Count - 1);
			Play(listBox1.Items[index] as Song);
		}
		private void Play(Song song)
		{
			try
			{
				player.SoundLocation = song.Path;
				player.Play();
				tbPlaying.Text = song.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Mute_Click(object sender, EventArgs e)
		{
			//TODO
		}
	}
}
