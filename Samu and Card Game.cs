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

                //int  N = 5;
                //int M = 6;
                //string[] cards = { "1 1", "1 1", "0 -4" };
                string[] input = Console.ReadLine().Split(' ');
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                int k = int.Parse(Console.ReadLine());


                int fila = 1, col = 1;
                int total_saltos = 0;

                for (int i = 0; i < k; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    int a = int.Parse(s[0]);
                    int b = int.Parse(s[1]);

                    // Console.WriteLine(a + " " + b);
                    while (fila + a >= 1 && col + b >= 1
                        && fila + a <= N && col + b <= M)
                    {
                        fila += a;
                        col += b;
                        total_saltos++;
                    }
                }

                //Console.WriteLine(fila + " " + col);
                Console.WriteLine(total_saltos);


            }

            Console.ReadLine();
        }
    }
}
