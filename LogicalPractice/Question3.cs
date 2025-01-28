using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question3
    {
        //Swap Values without using any variable a=10, b=12.
        public void application()
        {
            int a = 10;
            int b = 12;
            //a = a ^ b;
            //b = a ^ b;
            //a = a ^ b;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} and b = {b}");
        }
    }
}
