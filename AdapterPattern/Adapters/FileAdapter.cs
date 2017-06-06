using AdapterPattern.Convertors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapters
{
    public class FileAdapter : IConvertor
    {
        IFileConvertor fileConvertor;

        public void Convert(string fileType, string fileName)
        {
            if (fileType == "doc")
            {
                fileConvertor = new DocConvertor();
                fileConvertor.ConvertToDoc(fileName);
            }
            else if (fileType == "pdf")
            {
                fileConvertor = new PdfConvertor();
                fileConvertor.ConvertToPdf(fileName);
            }
        }
    }
}
