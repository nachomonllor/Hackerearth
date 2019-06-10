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


            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));

            long sum = a.Sum();


            Console.WriteLine( (sum - a.Max()) + " " +(sum - a.Min() ));


            Console.ReadLine();
        }
    }
}

