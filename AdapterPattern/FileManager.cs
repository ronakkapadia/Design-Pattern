using AdapterPattern.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class FileManager
    {
        public void ConvertFile(string fileType, string fileName)
        {
            if (fileType == "pdf" || fileType == "doc")
            {
                FileAdapter adapter = new FileAdapter();
                adapter.Convert(fileType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid FileType");
            }
        }
    }
}
