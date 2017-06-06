using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public abstract class Resource
	{
		public abstract string Name { get;}

		public abstract bool IsFile{ get; }

		public abstract bool IsDirectory { get; }

		public abstract List<Resource> GetChilds();
	}
}
