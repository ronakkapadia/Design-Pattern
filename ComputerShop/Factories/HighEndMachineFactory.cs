using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerShop.Devices;

namespace ComputerShop.Factories
{
    public class HighEndMachineFactory : IMachineFactory
    {
        public IHarddisk GetHardDisk()
        {
            return new HighEndHarddisk();
        }

        public IMonitor GetMonitor()
        {
            return new HighEndMonitor();
        }

        public IProcessor GetRam()
        {
            return new HighEndProcessor();
        }
        
    }
}
