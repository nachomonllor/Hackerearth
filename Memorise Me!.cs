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

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int elem in arr)
            {
                if (freq.ContainsKey(elem))
                {
                    freq[elem]++;
                }
                else
                {
                    freq[elem] = 1;
                }
            }


            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (freq.ContainsKey(x))
                {
                    Console.WriteLine(freq[x]);
                }
                else
                {
                    Console.WriteLine("NOT PRESENT");
                }
            }
            

            Console.ReadLine();
        }
    }
}


