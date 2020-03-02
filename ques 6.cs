https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/ques-6/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void PrintTriang(int n)
        {
            int len = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < len; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                len += 2;
            }
        }
        

        static void Main(string[] args)
        {

            // PrintTriang(5);
            int t = int.Parse(Console.ReadLine().Trim());

            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine().Trim());
                PrintTriang(n);
            }

            Console.ReadLine();
        }
    }
}
