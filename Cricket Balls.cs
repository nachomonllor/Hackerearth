using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        //static int maxCuadrado(string[] s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = 0; j < s[i].Length; j++)
        //        {

        //        }
        //    }
        //}


        public static int SumanK(int[] arr, int k)
        {

            //return "NO";
            Dictionary<int, int> hash =
                new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(arr[i])) hash[arr[i]]++;
                else hash[arr[i]] = 1;
            }


            int cont = 0;
            //foreach (KeyValuePair<int, int> kvp in hash)
            //{
            //    if (hash.ContainsKey(k - kvp.Key))
            //    {
            //        if (kvp.Key == k - kvp.Key)
            //        {
            //            cont += (kvp.Value * (kvp.Value - 1)) / 2;
            //        }
            //        else
            //        {
            //            cont += kvp.Value * hash[k - kvp.Key];
            //        }
            //    }
            //}

            //foreach (KeyValuePair<int, int> kvp in hash)
            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(k - arr[i]))
                {
                    if (hash.ContainsKey(arr[i]) && hash[k - arr[i]] > 0 && arr[i] == k - arr[i])
                    {
                        cont += (hash[arr[i]] * (hash[arr[i]] - 1)) / 2;
                        //hash.Remove(arr[i]);
                        hash[arr[i]] = 0;
                    }
                    else
                    {
                        if ( hash.ContainsKey( arr[i]) && hash.ContainsKey( k - arr[i]) && hash[k - arr[i]] > 0 && hash[arr[i]] > 0)
                        {
                            cont += hash[arr[i]] * hash[k - arr[i]];
                            hash[arr[i]] = 0;
                            hash[k - arr[i]] = 0;
                        }
                        //hash.Remove(arr[i]);
                    }
                    //hash.Remove(arr[i]);
                    
                }
            }

            return cont;

        }



        static void Main(string[] args)
        {



            int T = int.Parse(Console.ReadLine());

            while (T-- > 0)
            {

                int N = int.Parse(Console.ReadLine());
                int[] A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int K = int.Parse(Console.ReadLine());

                Console.WriteLine(SumanK(A, K));

            }

            //string input = "1 2 3 4 3";
            //int[] arr = Array.ConvertAll(input.Trim().Split(' '), e => int.Parse(e));

            //Console.WriteLine(SumanK(arr, 6));


            Console.ReadLine();

        }
    }
}


