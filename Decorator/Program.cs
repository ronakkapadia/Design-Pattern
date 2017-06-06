using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{

			Message message = new RSAMessageDecorator(new ZipCompressionMessageDecorator(new SHAMessageDecorator(new UnicodeMessage())));

			message.write("Hello");

			Console.WriteLine(message.Read());

			Console.ReadKey();
		}
	}
}
