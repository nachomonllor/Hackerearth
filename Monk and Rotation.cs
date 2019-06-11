using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] RotarDerecha(int[] arr, int k)
        {
            k = k % arr.Length;

            int[] rotado = new int[arr.Length];

            int i = 0;
            for (i = k; i < rotado.Length; i++)
            {
                rotado[i] = arr[i - k];
            }

            for (int j = i - k; j < arr.Length; j++)
            {
                rotado[j - (i - k)] = arr[j];
            }

            return rotado;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                foreach (int elem in RotarDerecha(a, k))
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

           // Console.ReadLine();
        }


    }
}
