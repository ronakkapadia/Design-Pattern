using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Command
{
	public class BoilingPlant
	{
		public event EventHandler onBoiled; 
		public void BoilWater()
		{
			for (int i = 0; i <= 150; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(100);
				if (i == 100)
				{
					onBoiled?.Invoke(null,null);
				}
			}
		}
	}
}
