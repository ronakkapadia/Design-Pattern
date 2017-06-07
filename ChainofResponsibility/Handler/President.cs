using ChainofResponsibility.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Handler
{
	public class President : Approver
	{
		public override void ProcessRequest(Request request)
		{
			if (request.Severity == 2)
			{
				request.Approved = true;
				Console.WriteLine("Request approved by President");
			}
			else
			{
				Console.WriteLine("Request forwarded to next level {0}", Next.Name);
				Next.ProcessRequest(request);
			}
		}
	}
}
