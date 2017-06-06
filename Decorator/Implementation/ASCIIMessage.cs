using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class ASCIIMessage : Message
	{
		private string msg;
		public override string Read()
		{
			return msg;
		}
		public override void write(string str)
		{
			msg = "ASCII Message" + str;
		}
	}
}
