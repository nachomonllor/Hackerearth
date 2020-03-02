https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/sumit-and-rohil/

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

            string[] nombres = new string[n];
            for (int i = 0; i < n; i++)
            {
                nombres[i] = Console.ReadLine();
            }
            //string[] nombres = {
            //"vinay",
            //"vainy",
            //"vinit",
            //"viint",
            //"avinash",
            //"aasivnh"
            //    };
            //int n = nombres.Length;

            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                char[] rev = nombres[i].ToCharArray();
                Array.Sort(rev);

                hs.Add(new string(rev) + " " + (nombres[i][0] + "" + nombres[i][nombres[i].Length - 1]));

            }

            //foreach (string elem in hs)
            //{
            //    Console.WriteLine(elem + " ");
            //}


            Console.WriteLine(hs.Count);


            Console.ReadLine();

        }
    }
}
