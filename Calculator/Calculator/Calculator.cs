using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathsCalculator
    {
        List<Operation> operations;
        public MathsCalculator()
        {
            operations = new List<Operation>();
            operations.Add(new Addition());
            operations.Add(new Subtraction());
            operations.Add(new Multiplication());
            operations.Add(new Division());
        }
        public double DoOperation(double number1, double number2, string operatorSymbol)
        {
            foreach (Operation operation in operations) 
            {
                if (operation.OperatorSymbol == operatorSymbol)
                {
                    return operation.DoOperation(number1, number2);
                }
            }
            throw new System.InvalidOperationException();
        }
        public int DoOperation(string operatorSymbol)
        {
            foreach (Operation operation in operations)
            {
                if (operation.OperatorSymbol == operatorSymbol)
                {
                    return operation.OperatorPrecedence;
                }
            }
            throw new System.InvalidOperationException();
        }

    }
} 
