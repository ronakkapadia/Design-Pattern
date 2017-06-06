using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Convertors
{
    public class PdfConvertor : IFileConvertor
    {
        public void ConvertToDoc(string fileName)
        {
            //Do Nothing
        }

        public void ConvertToPdf(string fileName)
        {            
            Console.WriteLine("Converting File to PDF Type...");
        }
    }
}
