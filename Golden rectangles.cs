using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static bool EsGolden(double x, double y)
        {
           


            return (x / y >= 1.6D && x / y <= 1.7D) || (y / x >= 1.6D && y / x <= 1.7D);
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                if (EsGolden(x, y))
                {
                    cont++;
                }

            }

            Console.WriteLine(cont);

            Console.ReadLine();
        }
    }
}