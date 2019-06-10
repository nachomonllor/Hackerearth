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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string e = Console.ReadLine(); //"eklpyqrbgjdwtcaxzsnifvhmou";

                int m = int.Parse(Console.ReadLine());
                string[] s = new string[m];
                for (int i = 0; i < m; i++)
                {
                    s[i] = Console.ReadLine();
                }


                string a = "abcdefghijklmnopqrstuvwxyz";

                Dictionary<char, char> comp = new Dictionary<char, char>();
                for (int i = 0; i < e.Length; i++)
                {
                    comp[e[i]] = a[i];
                }

                //transformar cada palabra
                string[] trans = new string[s.Length];

                int indice = 0;
                foreach (string elem in s)
                {
                    string pal = "";
                    for (int i = 0; i < elem.Length; i++)
                    {
                        pal += comp[elem[i]];
                    }
                    trans[indice++] = pal;
                }

    

                Array.Sort(trans, s);             

                foreach (string elem in s)
                {
                    Console.WriteLine(elem);
                }

            }


            Console.ReadLine();

        }
    }
}

