https://www.hackerearth.com/practice/algorithms/sorting/bubble-sort/practice-problems/algorithm/min-max-difference/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {

                string input_nm = Console.ReadLine().Trim();

                int n = int.Parse(input_nm.Split(' ')[0]);
                int m = int.Parse(input_nm.Split(' ')[1]);


                //int[] arr = { 1, 5, 3, 2, 4 };
                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                Array.Sort(arr);
                //int n = 5, m = 1;

                int dif = n - m;

                int min = 0;
                for (int i = 0; i < dif; i++)
                {
                    min += arr[i];
                }

                int max = 0;

                for (int i = arr.Length - 1; i >= arr.Length - dif; i--)
                {
                    max += arr[i];
                }

                Console.WriteLine(max - min);

            }

            Console.ReadLine();
        }

    }
}
