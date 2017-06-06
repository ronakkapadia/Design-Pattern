using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account act = new Account("Ashok", 10000);
            Account act1 = new Account("Ashok1", 11000);
            Account act2 = new Account("Ashok2", 12000);
            Console.WriteLine($"Name - {act.Name},Account Number - {act.AccountNumber}");
            Console.WriteLine($"Name - {act1.Name},Account Number - {act1.AccountNumber}");
            Console.WriteLine($"Name - {act2.Name},Account Number - {act2.AccountNumber}");
            Console.ReadKey();
        }
    }
}
