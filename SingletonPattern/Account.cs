using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Account
    {
        public int AccountNumber { get; private set; }

        public string Name { get; set; }

        public double Balance { get; set; }
        public Account(string name,int balance)
        {
            this.AccountNumber = AccountNumberGenerator.CreateInstance().NextNumber;
            this.Name = name;
            this.Balance = balance;
        }

    }
}
