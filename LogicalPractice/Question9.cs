using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question9
    {
        public void application()
        {
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            //Using inbuilt method Math.Sqrt()
            //double squareRoot = Math.Sqrt(input);
            //if (Math.Ceiling(squareRoot) == squareRoot)
            //{
            //    Console.WriteLine($"Square root of {input} is {squareRoot}");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} has no square root.");
            //}

            int? squareRoot = null;
            for(int i = 1; i <= input; i++)
            {
                if(i*i == input)
                {
                    squareRoot = i;
                    break;
                }
                if(i*i > input)
                {
                    break;
                }
            }
            if (squareRoot.HasValue)
            {
                Console.WriteLine($"Square root of {input} is {squareRoot}");
            }
            else
            {
                Console.WriteLine($"{input} has no square root");
            }
        }
    }
}
