using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailScanner test = new EmailScanner();
            Observer observer = new Observer(test);
            test.ConfigurateScanner(@"C:\Users\amartell_be\Downloads\configFile.txt");
            test.ScanEmail();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}