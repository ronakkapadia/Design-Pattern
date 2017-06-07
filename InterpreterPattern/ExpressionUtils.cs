using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class ExpressionUtils
    {
        internal static bool IsOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*")
                return true;
            else
                return false;
        }

        internal static IExpression GetOperator(string s, IExpression leftExpression, IExpression rightExpression)
        {
            switch (s)
            {
                case "+":
                    return new Add(leftExpression, rightExpression);
                case "-":
                    return new Sub(leftExpression, rightExpression);
                case "*":
                    return new Mul(leftExpression, rightExpression);
                default:
                    return null;
            }
        }
    }
}
