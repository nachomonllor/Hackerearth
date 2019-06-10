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
            int t = int.Parse(Console.ReadLine());

            long[] a = Array.ConvertAll(Console.ReadLine( ).Trim() .Split(' '), e => long.Parse(e));
            int q = int.Parse(Console.ReadLine());

            //long[] a = Array.ConvertAll("34 37 28 16 44 36 37 43 50 22 13 28 41 10 14 27 41 27 23 37 12 19 18 30 33 31 13 24 18 36 30 3 23 9 20 18 44 7 12 43 30 24 22 20 35 38 49 25 16 21 14 27 42 31 7 24 13 21 47 32 6 26 35 28 37 6 47 30 14 8 25 46 33 46 15 18 35 15 44 1 38 9 27 29 39 35 4 2 5 50 33 11 27 19 40 13 27 37 45 40".Trim().Split(' '), e => long.Parse(e)); 


            long[] sumas = new long[a.Length];

            long sum = 0;
            for (int i = 0; i < sumas.Length; i++)
            {
                sum += a[i];
                sumas[i] = sum;
            }

            for (int a0 = 0; a0 < q; a0++)
            {
                int query = int.Parse(Console.ReadLine());

                int indice = -1;

                for (int i = 0; i < sumas.Length; i++)
                {
                    if (sumas[i] >= query)
                    {
                        indice = i + 1;
                        break;
                    }
                }

                Console.WriteLine(indice);

            }




            Console.ReadLine();
        }
    }
}
