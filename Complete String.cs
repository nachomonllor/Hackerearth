https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/complete-string-4/
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

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                //string s = "qwertyuioplkjhgfdsazxcvbnm";
                string s = Console.ReadLine();

                string ans = "YES";
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                    if (!s.Contains(ch))
                    {
                        ans = "NO";
                        break;
                    }
                }
                Console.WriteLine(ans);
            }

            Console.ReadLine();

        }
    }
}

