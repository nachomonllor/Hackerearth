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

            //string s = "hackerearth";
            string s = Console.ReadLine();

            HashSet<char> hs = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                hs.Add(s[i]);
            }

            Console.WriteLine(new string(hs.ToArray()));

            Console.ReadLine();
        }
    }
}
