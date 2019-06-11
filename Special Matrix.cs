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
                int n = int.Parse(Console.ReadLine());
                string[] m = new string[n];
                for (int i = 0; i < n; i++)
                {
                    m[i] = Console.ReadLine();
                }

                //string[] m = {
                //    ".......",
                //    ".*.....",
                //    ".......",
                //    ".......",
                //    ".......",
                //    ".......",
                //    "......."
                //         };


                int filaMedio = m.Length / 2;
                int colMedio = m[0].Length / 2;

                int fa = -1, ca = -1;

                for (int i = 0; (fa == -1 && ca == -1) && i < m.Length; i++)
                {
                    for (int j = 0; j < m[i].Length; j++)
                    {
                        if (m[i][j] == '*')
                        {
                            fa = i;
                            ca = j;
                            break;
                        }
                    }
                }

                //Console.WriteLine(fa + " " + ca);
                Console.WriteLine(Math.Abs(filaMedio - fa) + Math.Abs(colMedio - ca));

            }

            Console.ReadLine();
        }
    }
}
