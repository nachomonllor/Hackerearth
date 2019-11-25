
https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/practice-problems/algorithm/help-natsu/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class GFG
    {


        static public void Main()
        {


            int t = int.Parse(Console.ReadLine().Trim());
            StringBuilder sb = new StringBuilder();

            while (t-- > 0)
            {
                //string[] tareas = {  "abcd",
                //                 "bcd",
                //                 "abc",
                //                 "abc",
                //                 "abc",
                //                 "bcd",
                //                 "bge",
                //                 "dbaa",
                //                 "bcd",
                //                 "bge",
                //    };

                int n = int.Parse(Console.ReadLine().Trim());
                string[] tareas = new string[n];
                for (int i = 0; i < n; i++)
                {
                    tareas[i] = Console.ReadLine().Trim();
                }


                Dictionary<string, int> frec = new Dictionary<string, int>();

                for (int i = 0; i < tareas.Length; i++)
                {
                    if (frec.ContainsKey(tareas[i]))
                    {
                        frec[tareas[i]]++;
                    }
                    else
                    {
                        frec[tareas[i]] = 1;
                    }
                }

                var items = from pair in frec
                            orderby pair.Value ascending, pair.Key ascending
                            select pair;

                foreach (KeyValuePair<string, int> kvp in items)
                {
                    // Console.WriteLine(kvp.Value + " " + kvp.Key);
                    sb.Append(kvp.Value);
                    sb.Append(" ");
                    sb.Append(kvp.Key);
                    sb.AppendLine();
                }

            }

            Console.WriteLine(sb.ToString());

            Console.ReadLine();

        }
    }
}
