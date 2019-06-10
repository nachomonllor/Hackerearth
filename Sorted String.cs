using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

             int t = int.Parse(Console.ReadLine());

             while (t-- > 0)
            {

                // string s = "aabcc"; //baacc
                //string s = "hackerearth"; //cktaaeehhrr // Console.ReadLine();
                string s = Console.ReadLine();

                SortedDictionary<char, int> frec = new SortedDictionary<char, int>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (frec.ContainsKey(s[i]))
                    {
                        frec[s[i]]++;
                    }
                    else
                    {
                        frec[s[i]] = 1;
                    }

                }


                var items = from pair in frec
                            orderby pair.Value ascending
                            select pair;

                string ans = "";
                foreach (KeyValuePair<char, int> kvp in items)
                {
                    ans += new string(kvp.Key, kvp.Value);
                }

                Console.WriteLine(ans);
 

            }


            Console.ReadLine();

        }
    }
}

