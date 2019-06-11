using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static string SumanK(int[] arr, int k)
        {


            //return "NO";
            Dictionary<int, int> hash =
                new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(arr[i])) hash[arr[i]]++;
                else hash[arr[i]] = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(k - arr[i]))
                {
                    if (k - arr[i] == arr[i])
                    {
                        if (hash[arr[i]] > 1)
                        {
                            return "YES";
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                    else
                    {
                        return "YES";
                    }
                }

            }

            return "NO";

        }



        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split(' ');

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            Console.WriteLine(SumanK(arr, K));


            Console.ReadLine();

        }
    }
}

