using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Mul : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Mul(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;

        }

        public int Interpret()
        {
            return leftExpression.Interpret() * rightExpression.Interpret();
        }
    }
}
