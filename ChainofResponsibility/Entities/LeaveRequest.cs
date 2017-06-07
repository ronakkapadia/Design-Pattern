using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Entities
{
	public class LeaveRequest : Request
	{
		public int NoOfLeaves { get; set; }
	}
}
