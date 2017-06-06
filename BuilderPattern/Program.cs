using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseConstructor constructor = new HouseConstructor();

            House concreteHouse = constructor.ConstructConcreteHouse();

            House woodenHouse = constructor.ConstructWoodenHouse();
            
            Console.ReadKey();
        }
    }
}
