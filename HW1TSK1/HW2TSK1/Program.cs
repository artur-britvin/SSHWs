using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW2TSK1
{

    class Program
    {
       
        static void DataeFilter(string indputDate)
        {
            Regex regex = new Regex(@"(1\d{3}|200\d|201[0-2])/(0[1-9]|1[0-2])/(0[1-9]|[1-2]\d|30) ([0-1]\d|2[0-3]):([0-4]\d|5[0-9])");
            MatchCollection matches = regex.Matches(indputDate);
            if (matches.Count > 0)
            {
                Console.WriteLine("Found matches:");
                foreach (Match match in matches)
                    Console.WriteLine($"\t{match.Value}");
            }
            else
            {
                Console.WriteLine("Matches not found");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter date in format \"YYYY/MM/DD hh:mm\"");
            Console.WriteLine("Date should be between 1000/01/01 and 2013/12/30");

            while (true)
            {
                Console.Write("\nEnter date: ");
                string date = Console.ReadLine();
                DataeFilter(date);
            }
        }
    }
}
