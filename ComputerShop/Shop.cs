using ComputerShop.Devices;
using ComputerShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Shop
    {
        private IMachineFactory factory;

        public Shop(IMachineFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleMachine()
        {
            IProcessor processor = factory.GetRam();
            IHarddisk hdd = factory.GetHardDisk();
            IMonitor monitor = factory.GetMonitor();
            //use all three and create machine

            processor.GetProcessor();
            hdd.StoreData();
            monitor.Display();

        }
    }
}
