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
           

            int k = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

          
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                HashSet<char> subs = new HashSet<char>();
                for (int j = i; j < s.Length; j++)
                {
                    subs.Add(s[j]);
                    if (subs.Count == k)
                    {
                        ans++;
                    }
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
