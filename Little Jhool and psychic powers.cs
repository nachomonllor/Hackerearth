https://www.hackerearth.com/problem/algorithm/psychic-powers/
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
            string b = Console.ReadLine();

            if (b.Contains("000000") || b.Contains("111111"))
            {
                Console.WriteLine("Sorry, sorry!");
            }
            else
            {
                Console.WriteLine("Good luck!");
            }


            Console.ReadLine();
        
        }
    }
}
