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
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                long k = int.Parse(input[3]);

                for (int x = 0; x < 100000; x++)
                {
                    long res = a * (x * x) + b * x + c;
                    if (res >= k)
                    {
                        Console.WriteLine(x);
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

