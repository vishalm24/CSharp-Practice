using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question6
    {
        //WAP to find the given string is Palindrome or not.
        public void application()
        {
            Console.WriteLine("Please enter 2 strings:");
            string str1 = Console.ReadLine();
            char[] arr1 = str1.ToCharArray();
            string str2 = Console.ReadLine();
            string str3 = "";
            if(str1.Length == str2.Length)
            {
                for (int i = 0; i < arr1.Length / 2; i++)
                {
                    char temp = arr1[i];
                    arr1[i] = arr1[arr1.Length - i - 1];
                    arr1[arr1.Length - i - 1] = temp;
                }
                str3 = new string(arr1);
                if (str3.Equals(str2))
                {
                    Console.WriteLine($"{str1} and {str2} are palindrome");
                }
                else
                {
                    Console.WriteLine($"{str1} and {str2} are not palindrome");
                }
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not palindrome");
            }
        }
    }
}
