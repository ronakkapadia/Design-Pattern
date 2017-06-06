using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Samsung : IMobile
    {
        public Samsung()
        {

        }

        public Samsung(int ram, string processor, double? cameraPixel, string OS = "Nougat")
        {
            this.Ram = ram;
            this.OSName = OS;
            this.Processor = processor;
            this.CameraQuality = cameraPixel;
        }
        public int Ram { get; set; }

        public string OSName { get; set; }

        public string Processor { get; set; }
        public double? CameraQuality { get; set; }

    }
}
