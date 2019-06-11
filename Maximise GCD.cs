using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static long gcd(long a, long b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        static void Main(string[] args)
        {

            //long[] arr = { 4, 8, 6, 9, 3 };
            int n = int.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            long GCD = 0;
            long max_gcd = 0;
            int min_ind = arr.Length - 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                GCD = gcd(GCD, arr[i]);
                if (GCD >= max_gcd)
                {
                    max_gcd = GCD;
                    min_ind = i;
                }
            }

            Console.WriteLine(min_ind );


            Console.ReadLine();
        }
    }
}


