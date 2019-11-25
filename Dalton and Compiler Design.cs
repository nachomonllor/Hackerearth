https://www.hackerearth.com/problem/algorithm/dalton-and-compiler-design/
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
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int izq = (int)(n / 2);
                int der = n - izq;

                Console.WriteLine(izq + " " + der);
            }

            Console.ReadLine();
        
        }
    }
}
