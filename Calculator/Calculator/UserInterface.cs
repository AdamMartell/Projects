using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Calculator
{
    class UserInterface
    {
        MathsCalculator calculator = new MathsCalculator();
        SpeechSynthesizer synth = new SpeechSynthesizer();



        public void Display()
        {
            synth.SetOutputToDefaultAudioDevice();
            double number1 = GetNumber();
            string operatorSymbol = GetOperator();
            double number2 = GetNumber();
            Console.WriteLine(calculator.DoOperation(number1, number2, operatorSymbol));

            //switch (operatorSymbol)
            //{
            //    case "+":
            //        Console.WriteLine("= " + calculator.Add(number1, number2));
            //        synth.Speak("= " + calculator.Add(number1, number2));
            //        break;
            //    case "-":
            //        Console.WriteLine("= " + calculator.Subtract(number1, number2));
            //        synth.Speak("= " + calculator.Subtract(number1, number2));
            //        break;
            //    case "*":
            //        Console.WriteLine("= " + calculator.Multiply(number1, number2));
            //        synth.Speak("= " + calculator.Multiply(number1, number2));
            //        break;
            //    case "/":
            //        try
            //        {
            //            Console.WriteLine("= " + calculator.Divide(number1, number2));
            //            synth.Speak("= " + calculator.Divide(number1, number2));
            //        }
            //        catch (System.DivideByZeroException e)
            //        {
            //            Console.WriteLine("You Can't Divide By 0 MORON!!! " + e.Message);
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Stop Hacking the Calculator");
            //        break;
            //}
        }
        private double GetNumber()
        {
            synth.SetOutputToDefaultAudioDevice();
            double number;
            Console.WriteLine("Enter a number: ");
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                synth.Speak(Convert.ToString(number));
                return number;
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Please enter a valid number " + e.Message);
                return GetNumber();
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Please enter a valid number " + e.Message);
                return GetNumber();
            }
        }
        private string GetOperator()
        {
            string operatorSymbol;
            Console.WriteLine("Enter an operator: ");
            operatorSymbol = Console.ReadLine();
            switch (operatorSymbol)
            {
                case "+":
                    synth.Speak(Convert.ToString(operatorSymbol));
                    return operatorSymbol;
                case "-":
                    synth.Speak(Convert.ToString(operatorSymbol));
                    return operatorSymbol;
                case "*":
                    synth.Speak(Convert.ToString(operatorSymbol));
                    return operatorSymbol;
                case "/":
                    synth.Speak(Convert.ToString(operatorSymbol));
                    return operatorSymbol;
                default:
                    synth.Speak("That is not a valid operator.  please try again");
                    return GetOperator();
            }

        }

    }
}
