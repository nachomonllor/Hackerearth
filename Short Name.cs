https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/short-name/

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

            //string s = "Mohd Kafeel Khan";
            string s = Console.ReadLine();

            string[] sp = s.Split(' ');

            for (int i = 0; i < sp.Length - 1; i++)
            {
                Console.Write(sp[i][0] + ". ");
            }
            Console.Write(sp[sp.Length - 1]);

            Console.ReadLine();

        }
    }
}


