//https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-//implementation/practice-problems/algorithm/erase-to-max-7b8c0ca3/

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

        static long MaximumSum(long[] arr)
        {
            Dictionary<long, int> dic =
                new Dictionary<long, int>();
            long suma_total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
                suma_total += arr[i];
            }

            long min = long.MaxValue;
            long min_key = 0;
            foreach(KeyValuePair<long,int> kvp in dic)
            {
                if(kvp.Key * kvp.Value < min)
                {
                    min = kvp.Key * kvp.Value;
                    min_key = kvp.Key;
                }
            }

            return suma_total - (dic[min_key] * min_key);
        }

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                Console.WriteLine(MaximumSum(arr));
            }
            Console.ReadLine();
        }

    }

}

