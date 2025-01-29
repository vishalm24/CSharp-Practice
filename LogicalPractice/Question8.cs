using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    //Find prime numbers from 1 ....n 
    internal class Question8
    {
        public void application()
        {
            Console.WriteLine("Please enter the number for prime numbers:");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> output = new List<int>();
            for(int i = 1; i < input; i++)
            {
                bool flag = true;
                for(int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    output.Add(i);
                }
            }
            Console.WriteLine($"Prime numbers till {input} are:");
            Console.Write(output[0]);
            for(int i = 1; i < output.Count; i++)
            {
                Console.Write(", " + output[i]);
            }
        }
    }
}
