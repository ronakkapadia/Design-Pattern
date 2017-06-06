using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class MessageDecorator : Message
	{
		Message message;

		public MessageDecorator(Message message)
		{
			this.message = message;
		}
		public override string Read()
		{
			return "Decorated Message" + message.Read();
 		} 

		public override void write(string str)
		{
			message.write(str);
		}
	}
}
