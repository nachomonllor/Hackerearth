https://www.hackerearth.com/practice/algorithms/sorting/quick-sort/practice-problems/algorithm/benny-and-gifts-marcheasy-3/


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
           // string s = "RRULDL";
            string s = Console.ReadLine().Trim();
            //string s = "RDUUDLRLDLDLDLRUUDLRLDDURUUUUUDUDUDDDDRLLLLLLRRRRLLL";
            Dictionary<string , int> dic = new Dictionary<string , int>();
            int x = 0, y = 0;
            dic.Add("0 0", 1);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    y++;
                }
                else if (s[i] == 'L')
                {
                    y--;
                }
                else if (s[i] == 'U')
                {
                    x--;
                }
                else
                {
                    x++;
                }
                if (dic.ContainsKey(x + " " + y))
                {
                    dic[x + " " + y]++;
                }
                else
                {
                    dic[x + " " + y] = 1;
                }
            }

            int cont = 0;
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                if (kvp.Value > 1)
                {
                    cont += kvp.Value - 1;
                }
            }

            Console.WriteLine(cont);

            Console.ReadLine();

        }
    }
}

