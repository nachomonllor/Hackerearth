using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

       

        static long maxSum(long[] a)
        {
            HashSet<long> hash = new HashSet<long>();


            for (int i = 0; i < a.Length; i++)
            {
                long max_so_far = a[i];
                long curr_max = a[i];
                hash.Add(max_so_far);
                for (int j = i + 1 ; j < a.Length; j++)
                {
                    curr_max = Math.Max(a[j], curr_max + a[j]);
                    max_so_far = Math.Max(max_so_far, curr_max);
                    hash.Add(max_so_far);
                }
            }

            return hash.Sum();
        }


        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
            Console.WriteLine(maxSum(arr));

            //int[] arr = { 5, -2, 7, -3 };
            //Console.WriteLine(maxSum(arr));


            Console.ReadLine();
        }
    }
}

