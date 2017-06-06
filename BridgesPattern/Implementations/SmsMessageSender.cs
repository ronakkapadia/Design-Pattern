using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesPattern.Implementations
{
	class SmsMessageSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine("Sending SMS to Client");
		}
	}
}
