https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/lexical-analyzer-3/
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
            //string[] s = new string[n];

            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string var = Console.ReadLine().Split('=')[0];
                hs.Add(var);
            }

            Console.WriteLine(hs.Count);





            Console.ReadLine();
        }


    }
}

