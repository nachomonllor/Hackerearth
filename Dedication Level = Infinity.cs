https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/baaki-che/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   

    class Program
    {

        static void solve(string[] input)
        {
            //int[] hash = new int[1001];
            //Dictionary<int, string> hash = new Dictionary<int, string>();
            string[] hash = new string[1001];
            //for (int i = 1000; i >= 0; i--)
            //{
            //    hash[i] = "";
            //}

            for (int i = 0; i < input.Length; i++)
            {
                string[] item = input[i].Split(' ');
                int n = int.Parse(item[1]);
                string t = item[0];
                hash[n] = t;

            }

            int cont = 0;
            for (int i = 1000; i >= 0; i--)
            {
                if (cont >= 3) break;
                if (hash[i]  != null)
                {
                    Console.WriteLine(hash[i]);
                    cont++;
                }
            }

        }

        static void Main(string[] args)
        {
            //string[] input = {
            //"Darshan 78",
            //"Harshad 90",
            //"Jaimin 87",
            //"Nirav 88",
            //"Hardik 1",
            //"Fenil 70",
            //"Lovlin 5"
            //    };

            int n = int.Parse(Console.ReadLine().Trim());

            string[] input = new string[n];
            int i = 0;
            while (n-- > 0)
            {
                input[i++] = Console.ReadLine().Trim();
            }


            solve(input);


            Console.ReadLine();
        }
    }
}
