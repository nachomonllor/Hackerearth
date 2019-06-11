using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            Dictionary<int, int> diccio = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (diccio.ContainsKey(a[i]))
                {
                    diccio[a[i]] = Math.Max(diccio[a[i]], b[i]);
                }
                else
                {
                    diccio[a[i]] = b[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(diccio[a[i]] + " ");
            }
            Console.WriteLine();

             

            Console.ReadLine();

        }
    }
}

