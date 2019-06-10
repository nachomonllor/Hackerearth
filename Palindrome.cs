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

            while (t-->0)
            {
                string s = Console.ReadLine();

                if (s == null)
                {
                    break;
                }
                int i = 0, j = s.Length-1;
                string ans = "YES";
                while (i < j)
                {
                    if (s[i] != s[j])
                    {
                        ans = "NO";
                        break;
                    }
                    i++;
                    j--;
                }

                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }
    }
}
