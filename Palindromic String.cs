https://www.hackerearth.com/problem/algorithm/palindrome-check-2/
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
            string s = Console.ReadLine();
            char[] r = s.ToCharArray();
            Array.Reverse(r);
            string rev = new string(r);

            if (s == rev)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }
}
