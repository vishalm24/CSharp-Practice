using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    //WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35],
    //without sorting, without using any built-in methods and without deleting duplicate elements.
    //What will be the time complexity?
    internal class Question1
    {
        public void application()
        {
            int[] arr = { 12, 35, 1, 10, 34, 1, 35 };
            int first;
            int second;
            if (arr[0] > arr[1])
            {
                first = arr[0];
                second = arr[1];
            }
            else
            {
                first = arr[1];
                second = arr[0];
            }
            for(int i=2; i<arr.Length; i++)
            {
                if (arr[i] > second)
                {
                    
                    if (arr[i] > first && arr[i] != second)
                    {
                        second = first;
                        first = arr[i];
                    }
                    second = arr[i];
                }
            }
            Console.WriteLine($"Second highest number: {second}");
        }
    }
}
