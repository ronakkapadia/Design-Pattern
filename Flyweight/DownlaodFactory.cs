using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public class DownlaodFactory
	{
		public Dictionary<string, Torrent> torrents = new Dictionary<string, Torrent>();

		public Torrent Download(string filename, string Url, double size)
		{
			Torrent torrent;
			var exists = torrents.ContainsKey(filename);
			if (!exists)
			{
				torrent = new Torrent(filename,  size, Url);
				torrents.Add(filename, torrent);
			}
			else
			{
				torrent = torrents[filename];
			}
			return torrent;

		}
			}
}
