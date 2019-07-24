https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/xsquare-and-double-strings-1/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        


        static string solve(string s)
        {
            char[] count = new char[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                if (count[s[i] - 'a'] > 1) return "Yes";
            }
            return "No";
        }

        static void Main(string[] args)
        {

            //string s = "lalxaxxxxxxxxxxx";
            //string s = "lala";
            //Console.WriteLine(EsDoble(s));

            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                string s = Console.ReadLine().Trim();
                Console.WriteLine(solve(s));

            }
            Console.ReadLine();
        }


    }
}
