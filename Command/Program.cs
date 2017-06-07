using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			BoilingPlant bp = new BoilingPlant();
			bp.onBoiled += Shutdown;
			bp.onBoiled += Popup;
			bp.onBoiled += CreateSound;

			bp.BoilWater();
			Console.ReadKey();

		}

		static void Shutdown(object sender, EventArgs e)
		{
			Console.WriteLine("Shutdown called");
		}

		static void Popup(object sender, EventArgs e)
		{
			Console.WriteLine("show pop up called");
		}

		static void CreateSound(object sender, EventArgs e)
		{
			Console.WriteLine("Create sound called");
		}
	}
}
