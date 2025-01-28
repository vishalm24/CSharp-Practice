using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question7
    {
        //Code to find even numbers in a list
        public void application()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter numbers and enter -1 for stopping ending process:");
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1) break;
                numbers.Add(input);
            }
            List<int> output = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0) output.Add(item);
            }
            Console.WriteLine("");
            for (int i = 0; i < output.Count; i++)
            {
                Console.Write(output[i]);
                if(i == output.Count - 1)
                {
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}
