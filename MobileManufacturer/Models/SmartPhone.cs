using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManufacturer.Models
{
    public class SmartPhone : Mobile
    {
        public SmartPhone(string model, double price, int cameraPixel) : base(model, price)
        {
            this.CameraQuality = cameraPixel;
        }

        public int CameraQuality { get; set; }

        public override void Call()
        {
            Console.WriteLine("Calling using Smart phone");
        }
    }
}
