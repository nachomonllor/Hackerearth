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
            int q = int.Parse(input[1]);
             
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            Array.Sort(a);

            while (q-- > 0)
            {
                int x = int.Parse(Console.ReadLine());

                int indice = Array.BinarySearch(a, x);

                if (indice >= 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }




            Console.ReadLine();
        }
    }
}

