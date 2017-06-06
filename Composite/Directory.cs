using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Directory : Resource
	{
		private string name;
		private List<Resource> childs;

		public Directory(string name)
		{
			this.name = name;
			childs = new List<Resource>();
		}

		public override bool IsDirectory => true;


		public override bool IsFile => false;


		public override string Name => name;

		public override List<Resource> GetChilds()
		{
			return childs;
		}

		public void AddChild(Resource child)
		{
			childs.Add(child);
		}
	}
}
