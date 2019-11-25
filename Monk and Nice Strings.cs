https://www.hackerearth.com/practice/algorithms/sorting/insertion-sort/practice-problems/algorithm/monk-and-nice-strings-3/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().Trim());
            //string[] input = { "a", "c", "d", "b" };
            string[] input = new string[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine().Trim();
            }

            for (int i = 0; i < input.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < i; j++)
                {
                    if (input[i].CompareTo(input[j]) > 0)
                    {
                        cont++;
                    }
                }
                Console.WriteLine(cont);
            }


            Console.ReadLine();

        }
    }
}