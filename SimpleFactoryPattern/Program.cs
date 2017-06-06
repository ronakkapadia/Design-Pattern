using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobile mobile;

            Console.WriteLine("1. Sony");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. iPhone");
            Console.WriteLine("Enter Your Choice");

            string ch = Console.ReadLine();

            if (ch == "1")
            {
                mobile = MobileFactory.Create(Mobile.Sony, "Snapdragon 810", 4, 21.00);
            }
            else if (ch == "2")
            {
                mobile = MobileFactory.Create(Mobile.Samsung, 2, "Snapdragon 810", 12.2, "Marshmallow");
            }
            else if (ch == "3")
            {
                mobile = MobileFactory.Create(Mobile.IPhone, 2, "IPhone", 12.2);
            }
            else
            {
                mobile = null;
            }




            if (mobile == null)
            {
                Console.WriteLine("Wrong Choice");
            }
            else
            {
                Console.WriteLine(mobile.GetType());
            }

            mobile = MobileFactory.Create(Mobile.Sony, "Snapdragon 810", 4, 21.00);
            Console.ReadKey();
        }
    }
}
