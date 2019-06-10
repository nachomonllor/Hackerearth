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

               
                string s = Console.ReadLine().Trim();

                //string s = "sajhags";

                Console.WriteLine(new string(s.Distinct().ToArray()));


            }

            Console.ReadLine();
        }
    }
}
