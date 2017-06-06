using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileManufacturer.Models;

namespace MobileManufacturer.Factories
{
    public class FeaturePhoneFactory : PhoneFactory
    {
        public override Mobile ProduceMobile()
        {
            Console.WriteLine("Enter Feature phone name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Feature phone price:");
            var price = double.Parse(Console.ReadLine());

            Mobile mobile = new FeaturePhone(name, price);
            return mobile;
        }
    }
}
