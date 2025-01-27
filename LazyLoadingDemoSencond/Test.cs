using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemoSencond
{
    internal class Test
    {
        private List<string> list = null;
        public Test()
        {
            Console.WriteLine("List Generated: ");
            list = new List<string>()
            {
                "Vishal", "Manas"
            };
        }
        public List<string> names
        {
            get
            {
                return list;
            }
        }
    }
}
