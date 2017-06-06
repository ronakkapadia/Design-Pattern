using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class File : Resource
	{
		private string name;

		public File(string name)
		{
			this.name = name;
		}

		public override bool IsDirectory => false;


		public override bool IsFile => true;


		public override string Name => name;
		
		public override List<Resource> GetChilds()
		{
			return null;
		}
	}
}
