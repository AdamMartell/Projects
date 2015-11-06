using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new AsyncAwaitDemo();
            demo.DoStuff();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
        }
        public class AsyncAwaitDemo
        {
            public async Task DoStuff()
            {
                await Task.Run(() =>
                {
                    LongRunningOperation();
                });
            }

            private static async Task<string> LongRunningOperation()
            {
                int counter1=1;

                for (int counter = 0; counter < 50000; counter++)
                {
                    Console.WriteLine(counter);
                }
                counter1++;
                return "Counter = " + counter1;
            }
        }
    }
}
