using ComputerShop.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Factories
{
    public interface IMachineFactory
    {
        IProcessor GetRam();
        IHarddisk GetHardDisk();
        IMonitor GetMonitor();
    }
}
