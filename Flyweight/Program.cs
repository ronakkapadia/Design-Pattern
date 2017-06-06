using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			DownlaodFactory torrentdownloader = new DownlaodFactory();
			Torrent t1 = torrentdownloader.Download("sample.mp4", "https://myfiles.com", 12450.00);
			Torrent t2 = torrentdownloader.Download("sample2.mp3", "https://myfiles.com", 1450.00);
			Torrent t3 = torrentdownloader.Download("sample3.mp3", "https://myfiles.com", 2450.00);
			Torrent t4 = torrentdownloader.Download("sample.mp4", "https://myfiles.com", 1240.00);
			Torrent t5 = torrentdownloader.Download("sample.mp3", "https://myfiles.com", 1245.00);

			Console.WriteLine(t1.Name + "  ,  " + t1.Size + "  ,  " + t1.Url);
			Console.WriteLine(t4.Name + "  ,  " + t4.Size + "  ,  " + t4.Url);
			Console.ReadLine();
		}
	}
}
