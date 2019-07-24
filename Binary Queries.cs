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
            string[] input = Console.ReadLine().Trim().Split(' ');

            int n = int.Parse(input[0]);
            int q = int.Parse(input[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            while (q-- > 0)
            {
                string[] query = Console.ReadLine().Trim().Split(' ');
                if (query.Length == 2) //flip
                {
                    int a = int.Parse(query[0]);
                    int b = int.Parse(query[1]);

                    if (arr[b - 1] == 0) arr[b - 1] = 1;
                    else if (arr[b - 1] == 1) arr[b - 1] = 0;
                }
                else //comprobar paridad
                {
                    int a = int.Parse(query[0]);
                    int b = int.Parse(query[1]);
                    int c = int.Parse(query[2]);

                    if (arr[c - 1] == 0)
                    {
                        Console.WriteLine("EVEN");
                    }
                    else
                    {
                        Console.WriteLine("ODD");
                    }

                }

            }


            Console.ReadLine();
        }

    }
}