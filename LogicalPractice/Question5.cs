using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question5
    {
        //Find the reverse of the string.
        public void application()
        {
            Console.WriteLine("Please enter the string:");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            for(int i = input.Length-1; i >=0; i--)
            {
                output.Append(input[i]);
            }
            Console.WriteLine($"Reverse of {input} is {output}");
        }
    }
}
