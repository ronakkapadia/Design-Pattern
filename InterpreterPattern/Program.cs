using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenString = "5 2 * 8 5 - +";

            Stack<IExpression> stack = new Stack<IExpression>();
            string[] tokenArray = tokenString.Split(' ');

            foreach (string s in tokenArray)
            {
                if (ExpressionUtils.IsOperator(s))
                {
                    IExpression rightExpression = stack.Pop();
                    IExpression leftExpression = stack.Pop();
                    IExpression oper = ExpressionUtils.GetOperator(s, leftExpression, rightExpression);
                    int result = oper.Interpret();
                    stack.Push(new Number(result));
                }
                else
                {
                    IExpression i = new Number(int.Parse(s));
                    stack.Push(i);
                }
            }

            Console.WriteLine(tokenString);
            Console.WriteLine(stack.Pop().Interpret());
            Console.ReadKey();
        }
    }
}

