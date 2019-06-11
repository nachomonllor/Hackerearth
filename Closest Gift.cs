using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {



        static bool esPrimo(long n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            long sqr = (long)Math.Sqrt(n);
            for (int i = 3; i <= sqr; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (esPrimo(n))
            {
                Console.WriteLine(0);
            }
            else
            {
                long der;
                long izq = der = n;
                while (izq >= 2 && !esPrimo(izq))
                {
                    izq--;
                }
                while (!esPrimo(der))
                {
                    der++;
                }

                 if (izq >= 2)
                 {
                     Console.WriteLine(Math.Min(n - izq, der - n));
                 }
                 else
                 {
                     Console.WriteLine(der - n);
                 }
            }


            Console.ReadLine();
        }
    }
}

