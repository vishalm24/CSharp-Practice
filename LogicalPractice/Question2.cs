using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LogicalPractice
{
    //WAP to reverse an integer without converting it to a string, without using any built-in methods. 
    internal class Question2
    {
        public void application()
        {
            Console.WriteLine("Please enter the number for reversing it:");
            long number = Convert.ToInt64(Console.ReadLine());
            long temp = number;
            long rev = 0;
            while(temp > 0)
            {
                long rem = temp % 10;
                rev = (rev * 10) + rem;
                temp /= 10;
            }
            Console.WriteLine($"Reverse of {number} is {rev}");
        }
    }
}
