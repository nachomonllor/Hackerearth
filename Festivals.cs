https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/suzakus-festivals-14dacd7c/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   

    class Program
    {

        static long[] print3largest(List<long> arr)
        {
            long first, second, third;

            // There should be atleast three elements 
            if (arr.Count < 3)
            {
                //Console.WriteLine("Invalid Input");
                arr.Sort();
                return arr.ToArray();
            }

            third = first = second = -1;
            for (int i = 0; i < arr.Count; i++)
            {
                // If current element is  
                // greater than first 
                if (arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first 
                // and second then update second 
                else if (arr[i] > second)
                {
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third)
                    third = arr[i];
            }

            //  Console.WriteLine("Three largest elements are " +
            //                    first + " " + second +
            //                    " " + third);

            return new long[] { first, second, third };

        }


        static string MenorNombre(string[] input)
        {
            string min = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                //if (min.CompareTo(input[i]) > 0)
                if(string.CompareOrdinal(min, input[i]) > 0)
                {
                    min = input[i];
                }

            }
            return min;

        }


        static void solve(string[] input)
        {
            Dictionary<string, List<long>> dic =
                new Dictionary<string, List<long>>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] sp = input[i].Split(' ');
                string s = sp[0];
                int x = int.Parse(sp[1]);

                if (dic.ContainsKey(s))
                {
                    dic[s].Add(x);
                }
                else
                {
                    dic[s] = new List<long>();
                    dic[s].Add(x);
                }
            }

            long max_sum = 0;
            //List<string> max_nombres = new List<string>();
            List<string> max_nombres = new List<string>();

            foreach (KeyValuePair<string, List<long>> kvp in dic)
            {
                long sum = 0;
                int cont = 0;

                List<long> pq = kvp.Value;
                //while (pq.Count > 0 && cont < 3)
                //{
                //    long deque = pq.Dequeue();
                //    sum += deque;
                //    //Console.Write(deque + " ");
                //    cont++;
                //}

               // pq.Sort();
               // pq.Reverse();

                long[] top3 = print3largest(pq);
                for (int i = 0; i < top3.Length && i < 3; i++)
                {
                    sum += top3[i];
                }

                //Console.WriteLine();

                if (sum > max_sum)
                {
                    max_sum = sum;
                    max_nombres = new List<string>();
                    max_nombres.Add(kvp.Key);
                }
                else if (sum == max_sum)
                {
                    max_nombres.Add(kvp.Key);
                }
            }

            //max_nombres.Sort();
           // max_nombres.Sort();
            //Console.WriteLine(max_nombres[0] + " " + max_sum);
            Console.WriteLine(MenorNombre(max_nombres.ToArray()) + " " + max_sum);

        }

        static void Main(string[] args)
        {

            //PriorityQueue<int> pq = new PriorityQueue<int>();

            //pq.Enqueue(60);
            //pq.Enqueue(10);
            //pq.Enqueue(60);
            //pq.Enqueue(10);
            //pq.Enqueue(2);
            //pq.Enqueue(60);

            //while (pq.Count > 0)
            //{
            //    int num = pq.Dequeue();
            //    Console.WriteLine(num);
            //}

            //string[] input = {
            //    "B 20",
            //    "A 2",
            //    "A 10",
            //    "A 10",
            //    "B 30",
            //    "A 30"
            //        };


            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine().Trim());

                string[] input = new string[n];
                for (int i = 0; i < n; i++)
                {
                    input[i] = Console.ReadLine().Trim();
                }
                solve(input);

            }

            //string[] s = {"aa", "AAA", "dfga", "eeA", "a", "ssss" };

            //Console.WriteLine(MenorNombre(s));

            Console.ReadLine();
        }
    }
}
