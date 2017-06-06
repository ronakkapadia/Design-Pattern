using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class ZipCompressionMessageDecorator : MessageDecorator
	{
		public ZipCompressionMessageDecorator(Message message) : base(message)
		{
		}

		public override void write(string str)
		{
			Console.WriteLine("Securing Message Zip compression");
			base.write(str);
		}

		public override string Read()
		{
			Console.WriteLine("Zip compression secured message:");
			return base.Read();
		}
	}
}
