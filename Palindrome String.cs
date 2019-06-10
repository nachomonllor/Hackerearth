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

                int i = 0, j = s.Length-1;
                string ans = "Palindrome";
                while (i < j)
                {
                    if (s[i] != s[j])
                    {
                        ans = "Not Palindrome";
                        break;
                    }
                    i++;
                    j--;
                }

                Console.WriteLine(ans);
            

            Console.ReadLine();
        }
    }
}

