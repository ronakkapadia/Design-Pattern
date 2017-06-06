using MobileManufacturer.Factories;
using MobileManufacturer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneFactory factory = new SmartPhoneFactory();
            Mobile smartPhone = factory.ProduceMobile();
            smartPhone.Call();

            PhoneFactory factory2 = new FeaturePhoneFactory();
            Mobile featurePhone = factory2.ProduceMobile();
            featurePhone.Call();

            Console.ReadKey();
        }
    }
}
