using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

       


        static void Main(string[] args)
        {
            //long[][] mat =
            //{
            //    new long[]{ 1,170, 48, 77},
            //    new long[]{67, 33, 22, 11},
            //    new long[]{55, 78,  4,  2}
            //};


            //long[] pos = ObtenerPosicion(mat, mat.LongLength, mat[0].LongLength, 78);
            //Console.WriteLine(pos[0] + " " + pos[1]);

            string[] input = Console.ReadLine().Trim().Split(' ');

            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            //long[][] matriz = new long[n][];
            int i = 0;
            long cont_fila = n;

            Dictionary<long, long[]> dic =
                new Dictionary<long, long[]>();

            while (cont_fila-- > 0)
            {
                long[] fila = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

                for(int j =0; j< m; j++)
                {
                    dic[fila[j]] = new long[] { i, j };
                }


                i++;
            }

            //Console.WriteLine("muestro la matriz");
            //for (int k = 0; k < n; k++)
            //{
            //    for (int l = 0; l < m; l++)
            //    {
            //        Console.Write(matriz[k][l] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int queryes = int.Parse(Console.ReadLine());
            while (queryes-- > 0)
            {
                long q = long.Parse(Console.ReadLine());
                //long[] pos = ObtenerPosicion(matriz, n, m, q);

                if (dic.ContainsKey(q))
                {
                    Console.WriteLine(dic[q][0] + " " + dic[q][1]);
                }
                else
                {
                    Console.WriteLine("-1 -1");
                }
                //Console.WriteLine(tupla.Item1 + " " + tupla.Item2);
                
            }

            Console.ReadLine();
        }
    }
}

