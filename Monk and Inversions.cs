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

                int[][] matriz = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    matriz[i] = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                }
                //int[,] matriz =
                //{
                //    {1, 2, 3},
                //    {4, 5, 6},
                //    {7, 8, 9}
                //};

                int cont = 0;

                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz.Length; j++)
                    {
                        for (int p = i; p < matriz.Length; p++)
                        {
                            for (int q = j; q < matriz.Length; q++)
                            {
                                if (matriz[i][j] > matriz[p][q])
                                {
                                    cont++;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine(cont);

            }


            Console.ReadLine();
        }
    }
}

