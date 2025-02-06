using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class Question12
    {
        //find the frequency of each and every character in a string and sort it in descending order.
        //Input: Engineer
        //Output : e3n2g1i1r1

        public void application()
        {
            string input = "Engineer".ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                    continue;
                }
                dict.Add(input[i], 1);
            }
            foreach (var item in dict)
            {
                Console.Write(item.Key + "" + item.Value);
            }
            //string str = "Engineer";
            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //string input = str.ToLower();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (!dict.ContainsKey(input[i]))
            //    {
            //        dict.Add(input[i], 1);
            //    }
            //    else
            //    {
            //        dict[input[i]]++;
            //    }
            //}
            //foreach (var item in dict)
            //{
            //    Console.Write(item.Key + item.Value);
            //}
        }
    }
}
