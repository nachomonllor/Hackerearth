using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Trim().Split(' ');
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


            for (int i = 0; i < Q; i++)
            {

                string[] linea = Console.ReadLine().Trim().Split(' ');
                int tipo = int.Parse(linea[0]);
                int x = int.Parse(linea[1]);
                int y = int.Parse(linea[2]);

                if (tipo == 1)
                {
                    arr[x] = y;
                }
                else if (tipo == 2)
                {
                    int sum = 0;
                    for (int j = x; j <= y; j++)
                    {
                        sum += arr[j];
                    }
                    Console.WriteLine(sum);
                }
            }


            Console.ReadLine();
        }
    }
}
