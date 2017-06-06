using BridgesPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesPattern.Abstraction
{
	public class ShortMessage : Message
	{
		public ShortMessage(IMessageSender sender)
		{
			this.sender = sender;
		}

		public override void SendMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}
