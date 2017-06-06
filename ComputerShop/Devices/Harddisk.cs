using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Devices
{ 

    public interface IHarddisk
    {
        void StoreData();
    }

    public class HighEndHarddisk : IHarddisk
    {
        public void StoreData()
        {
            Console.WriteLine("High End Harddisk");
        }
    }

    public class LowEndHarddisk : IHarddisk
    {
        public void StoreData()
        {
            Console.WriteLine("Low End Harddisk");
        }
    }
}
