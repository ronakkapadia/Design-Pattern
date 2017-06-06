using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Devices
{
    public interface IMonitor
    {
        void Display();
    }

    public class HighEndMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("High End Monitor");
        }
    }

    public class LowEndMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Low End Monitor");
        }
    }
}
