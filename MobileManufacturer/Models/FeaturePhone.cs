using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManufacturer.Models
{
    public class FeaturePhone : Mobile
    {
        public FeaturePhone(string model,double price) : base(model,price)
        {

        }

        public override void Call()
        {
            Console.WriteLine("Calling using Feature phone");
        }
    }
}
