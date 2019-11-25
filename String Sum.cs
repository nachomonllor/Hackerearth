https://www.hackerearth.com/problem/algorithm/string-sum/
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

            int ans = 0;
            foreach (char ch in s)
            {
                ans += ((int)ch) - 'a' + 1;
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
