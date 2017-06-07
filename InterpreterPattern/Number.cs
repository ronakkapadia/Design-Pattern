using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Number : IExpression
    {
        private int n;

        public Number(int n)
        {
            this.n = n;
        }

        public int Interpret()
        {
            return n;
        }
    }
}
