using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{

    public class NumberOperations
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operator { get; set; }

        public NumberOperations(double num1, double num2, string op)
        {
            Num1 = num1;
            Num2 = num2;
            Operator = op;
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case "+": return Num1 + Num2;
                case "-": return Num1 - Num2;
                case "*": return Num1 * Num2;
                case "/":
                    if (Num2 == 0)
                        throw new DivideByZeroException();
                    return Num1 / Num2;
                default:
                    throw new InvalidOperationException("Invalid operator");
            }
        }
    }
}