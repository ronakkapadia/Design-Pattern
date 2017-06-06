using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fManager = new FileManager();
            fManager.ConvertFile("doc", "test.doc");
            fManager.ConvertFile("pdf", "test.pdf");
            fManager.ConvertFile("xls", "test.xls");

            Console.ReadKey();
        }
    }
}
