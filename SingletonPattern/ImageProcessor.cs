using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class ImageProcessor
    {
        private static ImageProcessor processor;
        public static bool isFree = true;
        private ImageProcessor()
        {

        }
        public static ImageProcessor CreateInstance()
        {
            if(isFree)
            {
                if (processor == null)
                {
                    processor = new ImageProcessor();
                }                
                isFree = false;
                return processor;
            }
            return null;
        }
        public void Remove()
        {
            if (processor != null)
            {
                isFree = true;
            }
           // processor = null;
            isFree = true;
        }
        public void ProcessImage()
        {
            Console.WriteLine("Image Processing Started");
            Thread.Sleep(200);
            Console.WriteLine("image processing ended");
        }
    }
}
