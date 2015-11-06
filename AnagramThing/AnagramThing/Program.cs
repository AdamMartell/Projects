using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Object;
//using System.Text.Encoding;
//using System.Text.UnicodeEncoding;



namespace AnagramThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            string[] list1 = { "abc", "cba", "abc's", "cab's", "bat", "tab", "bac's", "'cds", "andrew's", "scd'", "ABC's", "s'CAB", "åsar", "råsa" };
            //test.ReadFromFile();
            //test.CountList(test.ReadFromFile());
            Console.WriteLine(DateTime.Now);
            test.RemoveUniques(test.AlphabatizeStrings(test.ReadFromFile()));
            //test.RemoveUniques(test.AlphabatizeStrings(list1));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
        public string[] ReadFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\amartell\Downloads\wordlist.txt");
            return lines;
        }
        public void CountMatches(List<string> test)
        {
            List<string> final = new List<string>() { };
            int TotalMatches = 0;
            for (int x = 0; x < test.Count(); x++)
            {
                for (int y = x + 1; y < test.Count(); y++)
                {
                    if (test[x] == test[y])
                    {
                        final.Add(test[y]);
                        TotalMatches++;
                    }
                };
            }
            List<string> finalnodups = final.Distinct().ToList();
            Console.WriteLine(finalnodups.Count());
        }
        public void RemoveUniques(List<string> list)
        {
            List<string> testList = new List<string>() { };
            for (int y = 0; y < list.Count()-1; y++)
            {
                if ((list[y + 1] == list[y]))
                {
                    testList.Add(list[y]);
                }
            }
            List<string> finalnodups = testList.Distinct().ToList();
            Console.WriteLine(finalnodups.Count());
        }
        public List<string> AlphabatizeStrings(string[] test)
        {
            List<string> list = new List<string>() { };
            for (int x = 0; x < test.Count(); x++)
            {
                list.Add(String.Concat(test[x].OrderBy(c => c)));
            }
            list.Sort();
            return list;
        }
    }
}
