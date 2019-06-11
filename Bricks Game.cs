using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().Trim());

            int sum = 0;
            for (int i = 1;  ; i++)
            {
                sum += i;
                if (sum >= n)
                {
                    Console.WriteLine("Patlu");
                    break;
                }
                sum += i * 2;
                if (sum >= n)
                {
                    Console.WriteLine("Motu");
                    break;
                }

            }


            Console.ReadLine();
        }
    }
}
