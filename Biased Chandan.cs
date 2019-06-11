using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyClass
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }


        bool[] marcas = new bool[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0)
            {
                //  marcas[i+1] = true;
                marcas[i] = true;

                int k = i;
                while (k >= 0 && marcas[k])
                {
                    k--;
                }
                marcas[k] = true;
            }
        }

        int sum = 0;
        for (int i = 0; i < marcas.Length; i++)
        {
            //Console.Write(marcas[i] + " ");
            if (!marcas[i])
            {
                sum += a[i];
            }
        }

        Console.WriteLine(sum);
    }
}
