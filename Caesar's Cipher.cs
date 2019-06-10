using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {       

       


        public static int Caesar(string s, string t)
        {
            if (s.Length != t.Length) return -1;
            Dictionary<char, char> diccio = new Dictionary<char, char>();

            string alfab = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int dif = 0;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < s.Length; i++)
            {
                char key = s[i], val = t[i];

                //Console.Write( Math.Abs(s[i] - t[i])+ " ");
                //hs.Add(Math.Abs(s[i] - t[i]));

                
                if (alfab.IndexOf(s[i]) > alfab.IndexOf(t[i]))
                {
                    dif = alfab.LastIndexOf(t[i]) - alfab.IndexOf(s[i]);
                }
                else
                {
                    dif =  alfab.IndexOf(t[i]) - alfab.IndexOf(s[i]);
                }

                hs.Add(dif);

                if(hs.Count > 1) return -1;

                if (diccio.ContainsKey(key))
                {
                    if (diccio[key] != val)
                    {
                        return -1;
                    }
                }
                else
                {
                    if (!diccio.ContainsValue(val))
                    {
                        diccio[key] = val;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }

            //Console.WriteLine();
            return hs.ToArray()[0];

        }


        static void Main()
        {
             //string s = "ABC";
             //  string t = "DEF";
             //  Console.WriteLine(Caesar(s, t));

            //-1
            //-1
            //-1
            //20
            //23


            //5

            //GX
            //PU

            //MKXKSZH
            //BPPHYKI

            //KEZPLVFJ
            //QMOPODOT

            //RJZRIML
            //LDTLCGF

            //U
            //R


            int q = int.Parse(Console.ReadLine());

            while (q-- > 0)
            {
                string s = Console.ReadLine();

                string t = Console.ReadLine();

                Console.WriteLine(Caesar(s, t));
            }


            Console.ReadLine();
        }



    }
}

