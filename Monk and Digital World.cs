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

            //string a = "abcd";
            //string b = "bcda";

            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();

           char[] a_ch = a.ToCharArray();
           char[] b_ch = b.ToCharArray();

           Array.Sort(a_ch);
           Array.Sort(b_ch);

           string ans = "YES";
           for (int i = 0; i < a.Length; i++)
           {
               if (a_ch[i] != b_ch[i])
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

