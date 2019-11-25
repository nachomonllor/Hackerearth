https://www.hackerearth.com/practice/algorithms/sorting/insertion-sort/practice-problems/algorithm/the-rise-of-the-weird-things-1/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { };
            int n = int.Parse(Console.ReadLine().Trim());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            int sumpares = 0, sumimpares = 0;
            List<int> pares = new List<int>(), impares = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    pares.Add(arr[i]);
                    sumpares += arr[i];
                }
                else
                {
                    impares.Add(arr[i]);
                    sumimpares += arr[i];
                }
            }

            pares.Sort();
            impares.Sort();

            foreach (int item in pares)
            {
                Console.Write(item + " ");
            }
            Console.Write(sumpares + " ");

            foreach (int item in impares)
            {
                Console.Write(item + " ");
            }
            Console.Write(sumimpares);

            Console.ReadLine();

        }
    }
}
