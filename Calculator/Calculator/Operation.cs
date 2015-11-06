using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    abstract class Operation
    {
        public abstract string OperatorSymbol
        {
            get;
        }
        public abstract int OperatorPrecedence
        {
            get;
        }
        public abstract double DoOperation(double number1, double number2);

        
    }
}
