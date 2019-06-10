using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            int ans = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] == m)
                {
                    ans = i + 1;
                    break;
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}

