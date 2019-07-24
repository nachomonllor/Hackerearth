https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/a-needle-in-the-haystack-1/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   

    class Program
    {



        //static string solve(string pattern, string text)
        //{

        //    if (pattern.Length > text.Length) return "NO" ;

        //    char[] pat_ch = pattern.ToCharArray();
        //    Array.Sort(pat_ch);


        //    for (int i = 0; i + pattern.Length <= text.Length; i++)
        //    {
        //        string subs = text.Substring(i, pattern.Length);
        //        char[] ch = subs.ToCharArray();
        //        Array.Sort(ch);

        //        if (new string(ch) == new string(pat_ch))
        //        {
        //            return "YES";
        //        }

        //    }

        //    return "NO";

        //}



        static bool compararDiccionarios(char[] dic1, char[] dic2)
        {
            for (int i = 0; i < 26; i++)
            {
                if (dic1[i] != dic2[i]) return false;
            }
            return true;
        }

        static char[] cargarDiccio(string s)
        {
            char[] dic = new char[26];

            for (int i = 0; i < s.Length; i++)
            {
                dic[s[i] - 'a']++;
            }
            return dic;
        }

        static string solve(string pattern, string text)
        {

            if (pattern.Length > text.Length) return "NO";
            char[] dic_pattern = cargarDiccio(pattern);

            string subs = text.Substring(0, pattern.Length);
            char[] dic_subs = cargarDiccio(subs);

            if (compararDiccionarios(dic_pattern, dic_subs))
            {
                return "YES";
            }

            for (int i = 0; i + pattern.Length < text.Length; i++)
            {

                dic_subs[text[i] - 'a']--;
                dic_subs[text[i + pattern.Length] - 'a']++;

                if (compararDiccionarios(dic_pattern, dic_subs))
                {
                    return "YES";
                }
            }

            return "NO";
        }


        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                string pattern = Console.ReadLine().Trim();
                string text = Console.ReadLine().Trim();

                Console.WriteLine(solve(pattern, text));

            }

            Console.ReadLine();
        }
    }
}
