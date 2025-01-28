using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question4
    {
        //Logic for anagram program with its time complexity. (for large strings).
        //Using arrays:
        public void application()
        {
            Console.WriteLine("Please enter 2 strings:");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            char[] arr1 = string1.ToLower().ToCharArray();
            char[] arr2 = string2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            bool flag = true;
            if(arr1.Length == arr2.Length)
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine($"{string1} and {string2} are not anagram.");
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{string1} and {string2} are not anagram.");
            }
            if(flag == true)
            {
                Console.WriteLine($"{string1} and {string2} are anagram.");
            }
        }

        ////Using dictionary:
        //public void application()
        //{
        //    Console.WriteLine("Please enter 2 strings:");
        //    string string1 = Console.ReadLine();
        //    string string2 = Console.ReadLine();
        //    Dictionary<char, int> keyvalue1 = new Dictionary<char, int>();
        //    Dictionary<char, int> keyvalue2 = new Dictionary<char, int>();
        //    foreach (char item in string1)
        //    {
        //        if (keyvalue1.ContainsKey(item))
        //        {
        //            keyvalue1[item] += 1;
        //            continue;
        //        }
        //        keyvalue1.Add(item, 1);
        //    }
        //    foreach (char item in string2)
        //    {
        //        if (keyvalue2.ContainsKey(item))
        //        {
        //            keyvalue2[item] += 1;
        //            continue;
        //        }
        //        keyvalue2.Add(item, 1);
        //    }
        //    bool flag = true;
        //    if(keyvalue1.Count == keyvalue2.Count)
        //    {
        //        foreach (var item in keyvalue1.Keys)
        //        {
        //            if(keyvalue1[item] != keyvalue2[item])
        //            {
        //                Console.WriteLine($"{string1} and {string2} are not anagram.");
        //                flag = false;
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{string1} and {string2} are not anagram.");
        //        flag = false;
        //    }
        //    if(flag )
        //    {
        //        Console.WriteLine($"{string1} and {string2} are anagram.");
        //    }
        //}
    }
}
