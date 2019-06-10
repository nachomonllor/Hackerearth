using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

       // is the string s a subsequence of the string t?
        public static int isSubsequence(String s, String t)
        {
            int m = s.Length;
            int n = t.Length;
            // if (m == 0) return true;
            int cont = 0;
            int i = 0;
            for (int j = 0; j < n; j++)
            {
                if (s[i] == t[j])
                {
                    cont++;
                    i++;
                }
                if (i == m)
                {
                    //return true;
                    return cont;
                }
            }

            return cont;
            //return false;
        }

        static void Main(string[] args)
        {

            //string s = "digger";
            //string t = "biggerdiagram";

            string s = Console.ReadLine().Trim();
            string t = Console.ReadLine().Trim();
           
            //string s = "informatika";
            //string t = "informatikainformatikainformatika";


            Console.WriteLine(isSubsequence(s, t));

            Console.ReadLine();
        }
    }
}
