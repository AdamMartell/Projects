using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectClass subject = new SubjectClass();
            ObserverClass observer = new ObserverClass(subject);
            subject.Value1 = 10;
            subject.Value1 = 100;
            observer.List();
            Console.ReadLine();

        }
    }
}
