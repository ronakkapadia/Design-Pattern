using ChainofResponsibility.Entities;
using ChainofResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			var leaveRequest1 = new LeaveRequest { Id = 1, Severity = 1, Subject = "Sick Leave", NoOfLeaves = 1, Approved = false };
			var leaveRequest2 = new LeaveRequest { Id = 1, Severity = 2, Subject = "Planned Leave", NoOfLeaves = 5, Approved = false };
			var leaveRequest3 = new LeaveRequest { Id = 1, Severity = 3, Subject = "Paternity Leave", NoOfLeaves = 10, Approved = false };
			var leaveRequest4 = new LeaveRequest { Id = 1, Severity = 4, Subject = "Sebbatical", NoOfLeaves = 100, Approved = false };

			var CEO = new CEO { Name = "CEO" };
			var president = new President { Name = "President", Next = CEO };
			var manager = new Manager { Name = "Manager", Next = president };

			manager.ProcessRequest(leaveRequest1);
			manager.ProcessRequest(leaveRequest2);
			manager.ProcessRequest(leaveRequest3);
			manager.ProcessRequest(leaveRequest4);
			Console.ReadKey();
		}
	}
}
