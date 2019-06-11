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
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        // Returns LCM of array elements
        static long findlcm(long[] arr, int n)
        {
            // Initialize result
            long ans = arr[0];

            // ans contains LCM of arr[0],..arr[i]
            // after i'th iteration,
            for (int i = 1; i < n; i++)
                ans = (((arr[i] * ans)) /
                        (gcd(arr[i], ans)));

            return ans;
        }

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));

                Console.WriteLine(findlcm(arr, arr.Length));

            }

            Console.ReadLine();
        }


    }
}
