using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void MostrarMatriz(int a, int b, int n, int p)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int min = Math.Min(p - Math.Abs(i - a),  p - Math.Abs(j - b));
                    if (min >= 0)
                    {
                        Console.Write(min + " ");
                    }
                    else
                    {
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        

        static void Main(string[] args)
        {

            // MostrarMatriz(3, 3, 7, 1);
            int n = int.Parse(Console.ReadLine().Trim());

            string[] input = Console.ReadLine().Trim().Split(' ');
            int i = int.Parse(input[0]);
            int j = int.Parse(input[1]);
            int p = int.Parse(input[2]);

            MostrarMatriz(i, j, n, p);

            //1000
            //123 321 65
            //MostrarMatriz(123, 321, 1000, 65);

            Console.ReadLine();
        }
    }
}


