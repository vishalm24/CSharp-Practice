using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question10
    {
        //WAP with 2 different logic, to find all duplicate numbers in an array.
        public void application()
        {
            Console.Write("Please enter total size of array:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[number];
            Console.WriteLine("Please enter the array:");
            for(int i = 0; i < number; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> output = new List<int>();
            for(int i = 0; i < number-1; i++)
            {
                if (!output.Contains(input[i]))
                {
                    for (int j = i + 1; j < number; j++)
                    {
                        if (input[i] == input[j])
                        {
                            output.Add(input[i]);
                            break;
                        }
                    }
                }
            }
            Console.Write("Input array: ");
            foreach (var item in input)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.Write("Duplicate numbers: ");
            foreach (var item in output)
            {
                Console.Write(item+" ");
            }
        }
    }
}
