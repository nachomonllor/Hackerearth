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
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int k = int.Parse(Console.ReadLine());

            SortedDictionary<int, int> diccio = new SortedDictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (diccio.ContainsKey(a[i]))
                {
                    diccio[a[i]]++;
                }
                else
                {
                    diccio[a[i]] = 1;
                }
            }

            int ans = -1;
            foreach (KeyValuePair<int, int> kvp in diccio)
            {
                if (kvp.Value == k)
                {
                    ans = kvp.Key;
                    break;
                }
            }

            Console.WriteLine(ans);


            Console.ReadLine();
        }
    }
}


