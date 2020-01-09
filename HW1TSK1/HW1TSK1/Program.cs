using System;
using System.Linq;

namespace HW1TSK1
{
    class Program
    {
        public static int GetSequence(int n)
        {
            string digitSequence = String.Empty;

            for (int i = 9; i > 0; i--)
            {
                if (n >= 0 && n <= 9)
                {
                    digitSequence += n;
                    return Convert.ToInt32(String.Concat(digitSequence.OrderBy(x => x)));
                }
                else if (i == 1 || n >= 0 && n <= 109)
                {
                    return -1;
                }
                else if (n % i == 0)
                {
                    n /= i;
                    digitSequence += i;
                    i = 9;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Please, input N number: ");
            Console.WriteLine("Result: {0} ", GetSequence(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
