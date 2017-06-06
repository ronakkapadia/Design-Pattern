using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerShop.Devices;

namespace ComputerShop.Factories
{
    class LowEndMachineFactory : IMachineFactory
    {
        public IHarddisk GetHardDisk()
        {
            return new LowEndHarddisk();
        }

        public IMonitor GetMonitor()
        {
            return new LowEndMonitor();
        }

        public IProcessor GetRam()
        {
            return new LowEndProcessor();
        }
    }
}
