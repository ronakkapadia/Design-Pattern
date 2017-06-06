using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Convertors
{
    public class DocConvertor : IFileConvertor
    {
        public void ConvertToDoc(string fileName)
        {
            Console.WriteLine("Converting File to Doc Type");
        }

        public void ConvertToPdf(string fileName)
        {
            //Do Nothing
        }
    }
}
