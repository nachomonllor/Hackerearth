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

           // string s = "babcddc";
            //string s = "aabcde";

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string s = Console.ReadLine();

                Dictionary<char, int[]> diccio = new Dictionary<char, int[]>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (diccio.ContainsKey(s[i]))
                    {
                        diccio[s[i]] = new int[] { diccio[s[i]][0], i };
                    }
                    else
                    {
                        diccio[s[i]] = new int[] { i, i };
                    }
                }

                int max_dif = 0;
                char max_char = ' ';
                foreach (KeyValuePair<char, int[]> kvp in diccio)
                {
                    //Console.WriteLine(kvp.Key + " -> " + (kvp.Value[1] - kvp.Value[0] + 1));
                    int dif = kvp.Value[1] - kvp.Value[0] + 1;
                    if (dif > max_dif)
                    {
                        max_dif = dif;
                        max_char = kvp.Key;
                    }
                }

                if (max_dif == 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(max_dif - 2);
                }

            }

            Console.ReadLine();

        }
    }
}

