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

            //string s = "aabc";
            string s = Console.ReadLine();

            Console.WriteLine(s.Length - s.Distinct().ToArray().Length);

            Console.ReadLine();
        }
    }
}
