using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW2TSK3
{
    class Program
    {
        static void TextReplace(List<string> input)
        {
            Regex regex;
            for (int i = 0; i < input.Count; i++)
            {
                regex = new Regex(input[i]);
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (regex.IsMatch(input[j]))
                    {
                        input.RemoveAt(j);
                    }
                }
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Adddd");
            list.Add("Bdddd");
            list.Add("Adddd");
            list.Add("Cdddd");
            TextReplace(list);
        }
    }
}
