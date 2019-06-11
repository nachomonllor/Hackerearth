using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool esPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int sqr = (int)Math.Sqrt(n);
            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matriz = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matriz[i] = new int[n];
                matriz[i] = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            }

            int ans = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    int sum = 0;
                    if (i - 1 >= 0)
                    {
                        sum += matriz[i - 1][j];
                    }
                    if (i + 1 < matriz.Length)
                    {
                        sum += matriz[i + 1][j];
                    }
                    if (j - 1 >= 0)
                    {
                        sum += matriz[i][j - 1];
                    }
                    if (j + 1 < matriz[i].Length)
                    {
                        sum += matriz[i][j + 1];
                    }

                    if (esPrimo(sum))
                    {
                        ans++;
                    }

                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
