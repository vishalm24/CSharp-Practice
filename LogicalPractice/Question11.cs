using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question11
    {
        //[80, 60, 10, 50, 30, 100, 0, 50]
        //    Find pairs whose sum = 100;
        //    Logic for above problem?
        //    What will be the complexity for it?
        //    Any better solution for the above problem?

        public void application()
        {
            Console.WriteLine("Please enter the numbers and for ending process type -1:");
            List<int> input = new List<int>();
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == -1)
                {
                    break;
                }
                input.Add(number);
            }
            List<List<int>> output = new List<List<int>>();
            for(int i = 0; i < input.Count -1; i++)
            {
                for(int j = i + 1; j <input.Count; j++)
                {
                    if (input[i] + input[j] == 100)
                    {
                        List<int> pairs = new List<int>();
                        pairs.Add(input[i]);
                        pairs.Add(input[j]);
                        output.Add(pairs);
                        pairs = null;
                    }
                }
            }
            Console.WriteLine("Input values");
            foreach (var item in input)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("Pairs which have total 100:");
            foreach (var item in output)
            {
                Console.Write("[");
                foreach (var item1 in item)
                {
                    Console.Write(item1+" ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
