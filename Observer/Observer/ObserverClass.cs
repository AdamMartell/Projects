using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ObserverClass
    {
        SortedList<string, string> sortedList;

        public ObserverClass(SubjectClass subject)
        {
            subject.ValueChanged += TheValueChanged;
        }
        private void TheValueChanged(Object sender, EventArgs e)
        {
            Console.Out.WriteLine("Value changed to " +
                ((SubjectClass)sender).Value1);
        }
        public void List()
        {
            sortedList.Add(null, "adam");
        }
    }
}
