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
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                int min = int.MaxValue;
                int cont_min = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        cont_min = 1;
                    }
                    else if (a[i] == min)
                    {
                        cont_min++;
                    }
                }
                //Console.WriteLine(cont_min);
                if (cont_min % 2 != 0)
                {
                    Console.WriteLine("Lucky");
                }
                else
                {
                    Console.WriteLine("Unlucky");
                }
            }

            Console.ReadLine();
        }
    }
}

