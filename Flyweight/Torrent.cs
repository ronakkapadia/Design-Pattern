using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	public class Torrent : ITorrent
	{

		public string Name { get; set; }
		public double Size { get; set; }
		public string Url { get; set; }

		public Torrent(string name, double size, string url)
		{
			this.Name = name;
			this.Size = size;
			this.Url = url;
		}

		public void Cancel()
		{
			throw new NotImplementedException();
		}

		public void Pause()
		{
			throw new NotImplementedException();
		}

		public void Start()
		{
			throw new NotImplementedException();
		}
	}
}
