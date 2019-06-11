using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string BatmanWins(string[] lines)
        {

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("xx.") || lines[i].Contains("x.x")
                    || lines[i].Contains(".xx"))
                {
                    return "YES";
                }
            }

            //concateno las columnas
            for (int j = 0; j < lines[0].Length; j++)
            {
                string col = "";
                for (int i = 0; i < lines.Length; i++)
                {
                    col += lines[i][j];
                }
                if (col.Contains("xx.") || col.Contains("x.x")
                    || col.Contains(".xx"))
                {
                    return "YES";
                }
            }

            string[] diags = { lines[0][1].ToString() + lines[1][2].ToString() + lines[2][3].ToString(),
                               lines[0][0].ToString() + lines[1][1].ToString() + lines[2][2].ToString(),
                               lines[1][1].ToString() + lines[2][2].ToString() + lines[3][3].ToString(),
                               lines[1][0].ToString() + lines[2][1].ToString() + lines[3][2].ToString(),

                               lines[0][2].ToString() + lines[1][1].ToString() + lines[2][0].ToString(),
                               lines[0][3].ToString() + lines[1][2].ToString() + lines[2][1].ToString(),
                               lines[1][2].ToString() + lines[2][1].ToString() + lines[3][0].ToString(),
                               lines[1][3].ToString() + lines[2][2].ToString() + lines[3][1].ToString()
                            };

            foreach (string d in diags)
            {
               if (d.Contains("xx.") || d.Contains("x.x")
                    || d.Contains(".xx"))
               {
                   return "YES";
               }
            }


            return "NO";
        }


        static void Main(string[] args)
        {
            //string[] lines = {
            //"xx..",
            //".oo.",
            //"x...",
            //"oox."
            //};

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] lines = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    lines[i] = Console.ReadLine();
                }

                Console.WriteLine(BatmanWins(lines));
            }


            Console.ReadLine();
        }

    }
}

