using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class IPhone : IMobile
    {
        public IPhone()
        {

        }
        public IPhone(int ram, string processor, string gpu)
        {
            this.Ram = ram;
            this.Processor = processor;
            this.GPU = gpu;
        }

        public int Ram { get; set; }
        public string Processor { get; set; }
        public string GPU { get; set; }
    }
}
