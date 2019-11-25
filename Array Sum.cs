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
            int n = int.Parse(Console.ReadLine().Trim());

            long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
            Console.WriteLine(arr.Sum());

            Console.ReadLine();
        }
    }
}
