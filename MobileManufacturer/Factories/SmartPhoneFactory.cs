using MobileManufacturer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManufacturer.Factories
{
    public class SmartPhoneFactory : PhoneFactory
    {
        public override Mobile ProduceMobile()
        {
            Console.WriteLine("Enter smart phone name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter smart phone price:");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter smart phone Camera Pixels:");
            var cameraPixels = int.Parse(Console.ReadLine());

            Mobile mobile = new SmartPhone(name, price, cameraPixels);
            return mobile;
        }
    }
}
