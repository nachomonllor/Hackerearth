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
            //string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            //string s = "abcaac";
            string s = Console.ReadLine();

            int cont = 0, max_cont=0;
            for (int i = 0; i < s.Length; i++)
            {
                if ("aeiou".Contains(s[i]))
                {
                    cont++;
                }
                else
                {
                    max_cont = Math.Max(max_cont, cont);
                    cont = 0;
                }
            }
            max_cont = Math.Max(max_cont, cont);
            Console.WriteLine(max_cont);

            Console.ReadLine();
        }
    }
}


