https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/shreya-and-non-palindrome/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {


        static int MaxLenNonPalin(string s)
        {
            if (s.Length == 1) return 0;
            int dist = s.Distinct().ToArray().Length;
            if (dist == 1) return 0;
            if ( dist == s.Length) return s.Length;


            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            if(s != new string (rev))
            {
                return s.Length;
            }

            Dictionary<char, int> dic =
                new Dictionary<char, int>();
            int max = 0;
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = i;
                }
                else
                {

                    flag = true;

                    if (i - 1 >= 0 && s[i - 1] != s[i])
                    {
                        max = Math.Max(max, i - 1 - dic[s[i]]);
                    }
                    if (i + 1 < s.Length && s[i + 1] != s[i])
                    {
                        max = Math.Max(max, i + 1 - dic[s[i]]);
                    }
                }
            }

            return max +1;
        }

        static void Main(string[] args)
        {

            // string s = "pqp";
            //string s = "aaa"; // Console.ReadLine().Trim();
            //string s = "abc";
            //string s = "f";
            string s = Console.ReadLine().Trim();
            //string s = "qwerqwer";

            Console.WriteLine(MaxLenNonPalin(s));


            Console.ReadLine();
        }

    }

}

