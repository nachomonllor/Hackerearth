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
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Array.IndexOf(a, k));
            


            Console.ReadLine();
        }
    }
}

