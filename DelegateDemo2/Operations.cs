using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    internal class Operations
    {
        public static Operations Load()
        {
            return new Operations();
        }
        public int Addition(int val1, int val2)
        {
            return val1 + val2;
        }
        public int Substration(int val1, int val2)
        {
            return val1 + val2;
        }
        public int Multiplication(int val1, int val2)
        {
            return val1 + val2;
        }
        public int Division(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
