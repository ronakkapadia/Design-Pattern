using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class AccountNumberGenerator
    {
        private static AccountNumberGenerator generator;

        private int number;

        private AccountNumberGenerator()
        {
            this.number = 101;
        }

        public static AccountNumberGenerator CreateInstance()
        {
            if (generator == null)
            {
                generator = new AccountNumberGenerator();
            }
            return generator;
        }

        public int NextNumber
        {
            get { return number++; }            
        }
    }
}
