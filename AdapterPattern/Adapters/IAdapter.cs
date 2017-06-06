using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapters
{
    public interface IConvertor // IAdapter
    {
        void Convert(string fileType, string fileName);
    }
}
