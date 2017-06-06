using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Convertors
{
    public interface IFileConvertor
    {
        void ConvertToPdf(string fileName);
        void ConvertToDoc(string fileName);
    }
}
