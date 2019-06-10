using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int notPalin(string s)
        {

            Dictionary<char, int> frec = s.ToCharArray() .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
            if (frec.Count == 1) return 0;


            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    string subs = s.Substring(i, j - i + 1);
                    char[] rev = subs.ToCharArray();
                    Array.Reverse(rev);
                    if (new string(rev) != subs)
                    {
                        return subs.Length;
                    }
                }
            }
            return 0;
        }


        static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(notPalin(s));
            Console.ReadLine();
        }
