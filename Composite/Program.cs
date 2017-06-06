using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Directory root = new Directory("My Directory");
			File file1 = new File("File1");
			File file2 = new File("File2");
			File file3 = new File("File3");
			Directory dir1 = new Directory("Dir1");
			Directory dir2 = new Directory("Dir2");
			Directory dir3 = new Directory("Dir3");

			root.AddChild(file1);
			root.AddChild(file2);
			root.AddChild(dir1);
			root.AddChild(dir2);
			root.AddChild(dir3);
			dir3.AddChild(file3);

			PrintNodes(root);

			Console.ReadKey();
		}

		private static void PrintNodes(Resource node)
		{
			Console.WriteLine(node.Name + " - " + ((node.IsDirectory) ? "Dir" : "File"));

			if (node != null && node.IsDirectory)
			{
				foreach(var n in node.GetChilds())
				{
					PrintNodes(n);
				}
			}
		}
	}
}
