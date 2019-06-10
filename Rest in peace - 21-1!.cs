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
                string s = Console.ReadLine();

                if (s.Contains("21") || int.Parse(s) % 21 == 0)
                {
                    Console.WriteLine("The streak is broken!");
                }
                else
                {
                    Console.WriteLine("The streak lives still in our heart!");
                }
            }



            Console.ReadLine();
        }
    }
}

