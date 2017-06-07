using ChainofResponsibility.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Handler
{
	public class CEO : Approver
	{
		public override void ProcessRequest(Request request)
		{
				request.Approved = true;
				Console.WriteLine("Request approved by CEO");
			
		}
	}
}
