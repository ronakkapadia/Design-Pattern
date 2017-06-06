using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class UnicodeMessage : Message
	{
		private string msg;
		public override string Read()
		{
			return msg;
		}
		public override void write(string str)
		{
			msg = "Unicode Message" + str;
		}
	}
}
