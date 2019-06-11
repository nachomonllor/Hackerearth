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

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            for (int i = 0; i < n; i++)
            {
                Console.Write((a[i] + b[i]) + " ");
            }

            Console.ReadLine();
        }
    }
}
