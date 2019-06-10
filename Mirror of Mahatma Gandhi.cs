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
                string s = Console.ReadLine();

                string ans = "YES";
                for (int i = 0; i < s.Length; i++)
                {
                    if ("2345679".Contains(s[i]))
                    {
                        ans = "NO";
                        break;
                    }
                }

                char[] rev = s.ToCharArray();
                Array.Reverse(rev);

                if (s != new string(rev))
                {
                    ans = "NO";
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}
