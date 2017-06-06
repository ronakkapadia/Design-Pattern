using BridgesPattern.Abstraction;
using BridgesPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			IMessageSender sender = new SmsMessageSender();
			Message message = new ShortMessage(sender);
			message.SendMessage("Hello Friends");

			IMessageSender sender2 = new MailMessageSender();
			Message message2 = new LongMessage(sender);
			message.SendMessage("Email message");

			Console.ReadKey();

		}
	}
}
