using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	class RSAMessageDecorator : MessageDecorator
	{
		public RSAMessageDecorator(Message message) : base(message)
		{
		}

		public override void write(string str)
		{
			Console.WriteLine("Securing Message RSA");
			base.write(str);
		}

		public override string Read()
		{
			Console.WriteLine("RSA secured message:");
			return base.Read();
		}
	}
}
