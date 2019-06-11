//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-//output/practice-problems/algorithm/play-with-numbers-2/


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class Query
        {
            public int l, r;

            public Query(int l, int r)
            {
                this.l = l;
                this.r = r;
            }

        }


        static void Ejecutar(long[] arr, List<Query> q)
        {
            long[] sum_arr = new long[arr.Length];

            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                sum_arr[i] = sum;
            }

            for (int i = 0; i < q.Count; i++)
            {
                int l = q[i].l-1;
                int r = q[i].r-1;

                if (l - 1 >= 0)
                {
                    Console.WriteLine(
                        Math.Floor( (double)(sum_arr[r] - sum_arr[l - 1]) /(r+1-l)  ) );
                }
                else
                {
                    Console.WriteLine(  Math.Floor( (double) (sum_arr[r]/(r+1))));
                }
            }

        }


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);

            long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            List<Query> que = new List<Query>();

            for(int i =0; i<q; i++)
            {
                string[] aux = Console.ReadLine().Trim().Split(' ');
                que.Add(new Query(int.Parse(aux[0]) , int.Parse(aux[1]) ));
            }

            Ejecutar(arr, que);



            Console.ReadLine();
        }
    }
}

