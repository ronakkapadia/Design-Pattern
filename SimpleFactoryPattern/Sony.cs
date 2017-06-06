using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Sony : IMobile
    {
        public Sony()
        {

        }

        public Sony(string processor, int ram, double cameraPixel)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.CamaraQuality = cameraPixel;
        }

        public int Ram { get; set; }

        public string Processor { get; set; }

        public double CamaraQuality { get; set; }
    }
}
