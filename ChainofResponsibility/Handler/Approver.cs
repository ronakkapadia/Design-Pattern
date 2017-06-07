using ChainofResponsibility.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
	public abstract class Approver
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Approver Next { get; set; }
		public abstract void ProcessRequest(Request request);
	}
}
