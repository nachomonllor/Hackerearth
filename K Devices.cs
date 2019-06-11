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
            //int n = 3, k = 3;

            //int[] x = { 1, -1, 1 };
            //int[] y = { 1, -1, -1 };

            string[] nk = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            long[] x = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
            long[] y = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            List<long> distancias = new List<long>();
            for (int i = 0; i < n; i++)
            {
                long dist = (long) Math.Ceiling( Math.Sqrt(x[i] * x[i] + y[i] * y[i]));
                distancias.Add(dist);
                //Console.WriteLine(dist);
            }

            distancias.Sort();

            int cont = 0;
            long min_radius = -1;
            for (int i = 0; cont<k && i < distancias.Count; i++)
            {
                //Console.WriteLine(distancias[i]);
                min_radius = distancias[i];
                cont++;
            }

            Console.WriteLine(min_radius);

            Console.ReadLine();
        }
    }
}
