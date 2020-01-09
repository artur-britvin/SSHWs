using System;
using System.Collections.Generic;

namespace HW1TSK2
{
    class Program
    {
        static int res = 0;
        private static void moveBrick(ref List<int> list, int index)
        {

            list[index]--;
            list[index + 1]++;
            while (list[index] >= list[index + 1])
            {
                res++;
                moveBrick(ref list, index + 1);


            }
            if (list[index] < list[index + 1])
            {
                list[index]++;
                list[index + 1]--;
            }
            for (int j = index + 2; j < list.Count; j++)
            {
                list[index + 1] += list[j];
                list[j] = 0;
            }

        }

        public static int foo(int n)
        {
            List<int> list = new List<int>(2);

            if (n <= 5 && n >= 500)
            {
                return -1;
            }

            list.Add(n);



            list.Add(0);
            list.Add(0); list.Add(0); list.Add(0);
            list.Add(0); list.Add(0);
            while (list[0] >= list[1])
            {
                moveBrick(ref list, 0);
            }



            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(foo(6));
        }
    }
}
