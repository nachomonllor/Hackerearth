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
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            int cont = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                x -= arr[i];
                cont++;
                if (x <= 0)
                {
                    break;
                }
               
            }

            Console.WriteLine(cont);

            Console.ReadLine();
        }
    }
}
