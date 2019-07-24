using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        class Rango
        {
            public int left;
            public int rigth;

            public Rango(int l, int r)
            {
                this.left = l;
                this.rigth = r;
            }
        }

        static void solve(double[] arr)
        {
            double[] arr_sum = new double[arr.Length];
            double sum =0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                arr_sum[i] = sum;
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(i + " " + arr_sum[i]);
            //}
            int cont = 0;

            double prom_total = sum / arr_sum.Length;

            List<Rango> lista = new List<Rango>();

            for (int i = 0; i < arr_sum.Length; i++)
            {
                for (int j = i; j < arr_sum.Length; j++)
                {
                    double suma_subarray = 0;
                    if (i > 0)
                        suma_subarray = arr_sum[j] - arr_sum[i - 1];
                    else
                        suma_subarray = arr_sum[j];

                    double prom = suma_subarray / (j - i + 1);

                    double den = (arr.Length - (j - i + 1));
                    if(den == 0) den = 1;
                    double prom_resto = (sum - suma_subarray) / den;

                    if (prom > prom_resto)
                    {
                       // Console.WriteLine((i+1) + " " + (j+1));
                        lista.Add(new Rango(i + 1, j + 1));
                        cont++;
                    }

                }
            }

            Console.WriteLine(cont);
            foreach (Rango item in lista)
            {
                Console.WriteLine(item.left + " " + item.rigth);
            }

        }

        static void Main(string[] args)
        {

            //double[] arr = { 3, 4, 2 };

            //solve(arr);
            int n = int.Parse(Console.ReadLine().Trim());

            double[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => double.Parse(e));

            solve(arr);


            Console.ReadLine();
        }
    }
}
