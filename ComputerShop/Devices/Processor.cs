using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Devices
{
    public interface IProcessor
    {
        void GetProcessor();
    }

    public class HighEndProcessor : IProcessor
    {
        public void GetProcessor()
        {
            Console.WriteLine("High End Processor");
        }
    }

    public class LowEndProcessor : IProcessor
    {
        public void GetProcessor()
        {
            Console.WriteLine("Low End Processor");
        }
    }
}
