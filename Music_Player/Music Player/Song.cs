using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
