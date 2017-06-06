using BridgesPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesPattern.Abstraction
{
	public abstract class Message
	{
		public IMessageSender sender { get; set; }

		public abstract void SendMessage(string message);
	}
}
