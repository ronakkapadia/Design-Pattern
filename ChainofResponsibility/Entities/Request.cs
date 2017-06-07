using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Entities
{
	public class Request
	{
		public int Id { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public int Severity { get; set; }
		public bool Approved { get; set; }
	}
}
