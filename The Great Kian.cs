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

            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e)); 

           // int[] a = { 1, 2, 3, 4, 5 };
            int x = 0, y = 1, z = 2;

            long s1 = 0, s2 = 0, s3 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == x)
                {
                    s1 += a[i];
                    x += 3;
                }
                else if (i == y)
                {
                    s2 += a[i];
                    y += 3;
                }
                else if (i == z)
                {
                    s3 += a[i];
                    z += 3;
                }

            }

            Console.WriteLine(s1 + " " + s2 + " " + s3);

            Console.ReadLine();
        }
    }
}
