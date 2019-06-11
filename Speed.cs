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

                long n = int.Parse(Console.ReadLine());
                long[] a = Array.ConvertAll(Console.ReadLine().Trim() .Split(' '), e => long.Parse(e));

                // int[] a = { 4, 5, 1, 2, 3 };
                //int[] a = { 8, 3, 6 };

                long[] real_speed = new long[a.Length];
                real_speed[0] = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] >= real_speed[i - 1])
                    {
                        real_speed[i] = real_speed[i - 1];
                    }
                    else if (a[i] < real_speed[i - 1])
                    {
                        real_speed[i] = a[i];
                    }
                }

                int cont_max = 0;
                for (int i = 0; i < real_speed.Length; i++)
                {
                    //Console.Write(real_speed[i] + " ");
                    if (a[i] == real_speed[i])
                    {
                        cont_max++;
                    }
                }

                Console.WriteLine(cont_max);
            }


            Console.ReadLine();
        }
    }
}


