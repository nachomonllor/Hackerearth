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

               // string s = "zazabcdefghgfgfededededcdefghghijkjihihgfe";
                string s = Console.ReadLine().Trim();
                s = s.ToLower();
                string ans = "YES";
                for (int i = 0; i + 1 < s.Length; i++)
                {
                    if ((s[i] == 'a' && (s[i + 1] != 'z' && s[i + 1] != 'b')) || (s[i] == 'z' && ( s[i + 1] != 'a' && s[i + 1] != 'y')))
                    {
                        ans = "NO";
                        break;
                    }
                    else if ((s[i] != 'a' && s[i] != 'z') && Math.Abs((s[i]-97) - (s[i + 1]-97)) != 1)
                    {
                      //  Console.WriteLine((int)s[i] -97+1);
                      //  Console.WriteLine(s[i + 1] - 97+1);
                      //  Console.WriteLine(Math.Abs(((int)s[i] - 97 + 1) - ((int)s[i + 1]  -97 + 1)));
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
