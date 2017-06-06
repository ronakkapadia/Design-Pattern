using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesPattern.Implementations
{
	public class MailMessageSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine("Sending mail to Client");
		}
	}
}
