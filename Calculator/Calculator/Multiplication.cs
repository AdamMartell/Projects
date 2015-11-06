using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Multiplication : Operation
    {
        public override string OperatorSymbol
        {
            get
            {
                return "*";
            }
        }
        public override int OperatorPrecedence
        {
            get
            {
                return 1;
            }
        }
        public override double DoOperation(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
