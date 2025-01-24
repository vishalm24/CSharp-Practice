using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoThird
{
    internal class Division
    {
        public void Divide(int num1, int num2)
        {
            Console.WriteLine($"{num1} / {num2} = {(float)num1 / (float)num2}");
        }
    }
}
