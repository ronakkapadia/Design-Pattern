using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class SHAMessageDecorator : MessageDecorator
	{
		public SHAMessageDecorator(Message message) : base(message)
		{
		}

		public override void write(string str)
		{
			Console.WriteLine("Securing Message SHA");
			base.write(str);
		}

		public override string Read()
		{
			Console.WriteLine("SHA secured message:");
			return base.Read();
		}
	}
}
