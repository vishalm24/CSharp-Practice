using GenericsWthConstraints.Generic_Example.IEnnumarable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Generic_Example
{
    internal class GenericImplementation
    {
        public void implementation()
        {
            List<int> list = new List<int>() { 75, 26, 38, 26, 45, 98, 23, 65, 34};
            Console.WriteLine("List implementation:  ");
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            Numarable<int> numarable = new Numarable<int>();
            Console.WriteLine("After sorting IEnumerable: ");
            IEnumerable<int> sorted = numarable.sorting(list);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            IEnumerator<int> abc = sorted.GetEnumerator();
            IEnumerator<int> output = list.GetEnumerator();
            while (output.MoveNext())
            {
                Console.WriteLine(output.Current);
            }
            output.Reset();
        }
    }
}
