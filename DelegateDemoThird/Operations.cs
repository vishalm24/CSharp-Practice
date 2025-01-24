using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoThird
{
    internal class Operations
    {
        public void Addition(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public void Substraction(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
    }
}
