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
            string s = Console.ReadLine();

            string ans = "YES";
            string vocales = "aeiou";
            for (int i = 0; i < vocales.Length; i++)
            {
                if (!s.Contains(vocales[i]))
                {
                    ans = "NO";
                    break;
                }
            }
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}


