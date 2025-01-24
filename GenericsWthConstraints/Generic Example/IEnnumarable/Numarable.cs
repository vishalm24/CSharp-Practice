using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Generic_Example.IEnnumarable
{
    internal class Numarable<T> where T : struct
    {
        //Let's sort list and send it back with IEnumerable
        public IEnumerable<T> sorting(List<T> list)
        {
            list.Sort();
            return list;
        }
    }
}
