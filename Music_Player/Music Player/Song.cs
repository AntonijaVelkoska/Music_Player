using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Music_Player
{
	class Song
	{
		public string Path { get; set; }
		public Song(string path) { this.Path = path; }
		public override string ToString()
		{
			int index = Path.LastIndexOf('\\');
			return Path.Substring(index+1);
		}
		public void Play(SoundPlayer player)
		{
			try
			{
				player.SoundLocation = this.Path;
				player.Play();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
