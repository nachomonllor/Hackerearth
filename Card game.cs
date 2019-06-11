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

            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            int m = int.Parse(Console.ReadLine());
            long[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            //int n = 3;
            //int[] a = { 1, 3, 10 };
            //int m = 2;
            //int[] b = { 3, 4 };

            //int n = 3;
            //int[] a = {2,2,2 };
            //int m = 2;
            //int[] b = { 3,3,3,3 };


            //int n = 3;
            //int[] a = { 0,0,0 };
            //int m = 2;
            //int[] b = { 1,2};


            //int n = 3;
            //int[] a = {4,4, 10 };
            //int m = 2;
            //int[] b = { 3, 4 };

            //int n = 3;
            //int[] a = { 0,0,0};
            //int m = 2;
            //int[] b = { 0,0,0,0};


            long max_b = b.Max();
 
         
            long[] copia = new long[a.Length];
            

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= max_b)
                {
                    //a[i] = max_b + 1;
                    copia[i] = max_b + 1;
                    
                }
                else
                {
                    copia[i] = a[i];
                }
            }

            long sum = 0;
            for (int i = 0; i < copia.Length; i++)
            {
                sum += copia[i] - a[i];
            }
   
            //Console.WriteLine();
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}

