// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] str = { "eat", "tea", "tan", "ate", "nat", "bat" };
        List<List<string>> output = new List<List<string>>();
        List<int> index = new List<int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (!index.Contains(i))
            {
                string str1 = sortString(str[i]);
                List<string> list = new List<string>();
                list.Add(str[i]);
                index.Add(i);
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (!index.Contains(j))
                    {
                        string str2 = sortString(str[j]);
                        if (str1.Equals(str2))
                        {
                            list.Add(str[j]);
                            index.Add(j);
                        }
                    }
                }
                output.Add(list);
            }
        }
        output.Reverse();
        foreach (var item in output)
        {
            Console.Write("[ ");
            foreach (var str3 in item)
            {
                Console.Write(str3 + " ");
            }
            Console.Write("] ");
        }
    }
    public static string sortString(string str)
    {
        char[] ch = str.ToCharArray();
        Array.Sort(ch);
        return new String(ch);
    }
}