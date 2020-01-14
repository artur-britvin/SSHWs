using System;
using System.Text.RegularExpressions;

namespace HW2TSK2
{
    class Program
    {
        static void IPFilter(string indputIP)
        {
            Regex regex = new Regex(@"(0x[A-D][A-D]|0x[A-D]F|0xF[A-D]|0xFF|0x[1-9]\d|0x[A-B]\d|0x\d[A-B]|0xF\d|0x\dF|0x\d|0x\d|[1-9]\d|1\d{2}|[0-2][0-5][0-5]|[0-9]).(0x[A-D][A-D]|0x[A-D]F|0xF[A-D]|0xFF|0x[1-9]\d|0x[A-B]\d|0x\d[A-B]|0xF\d|0x\dF|0x\d|0x\d|[1-9]\d|1\d{2}|[0-2][0-5][0-5]|[0-9]).(0x[A-D][A-D]|0x[A-D]F|0xF[A-D]|0xFF|0x[1-9]\d|0x[A-B]\d|0x\d[A-B]|0xF\d|0x\dF|0x\d|0x\d|[1-9]\d|1\d{2}|[0-2][0-5][0-5]|[0-9]).(0x[A-D][A-D]|0x[A-D]F|0xF[A-D]|0xFF|0x[1-9]\d|0x[A-B]\d|0x\d[A-B]|0xF\d|0x\dF|0x\d|0x\d|[1-9]\d|1\d{2}|[0-2][0-5][0-5]|[0-9])");
            MatchCollection matches = regex.Matches(indputIP);
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
            Console.WriteLine("Please, enter IP: ");

            while (true)
            {
                Console.Write("\nEnter IP: ");
                string date = Console.ReadLine();
                IPFilter(date);
            }
        }
    }
}
