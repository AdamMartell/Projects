using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "12.53+2.6/1.1-4.1*6.51";
            //Regex regex = new Regex("(\\d*\\.?\\d*)");
            //Regex regex1 = new Regex("[*+/-]");
            //MatchCollection matches = regex.Matches(input);
            //MatchCollection matches1 = regex1.Matches(input);
            //int x = 1;
            //List<string> list = new List<string>() { };
            //foreach (Match match in matches)
            //{
            //    list.Add(Convert.ToString(match));
            //}
            //foreach (Match match in matches1)
            //{
            //    list.Insert(x, Convert.ToString(match));
            //    x += 3;
            //}
            //foreach (string element in list)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.ReadLine();



            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            //synth.speak("hello");
            Console.WriteLine("please enter your name: ");
            string name = Console.ReadLine();
            synth.Speak("hello " + name + " welcome to our calculator");
            UserInterface test = new UserInterface();
            while (true)
            {
                test.Display();
            }
        }
    }
}
