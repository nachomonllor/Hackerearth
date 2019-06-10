using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int Sum(string s)
        {
            int suma = 0;
            for (int i = 0; i < s.Length; i++) suma += s[i] - 'a' + 1;
            return suma;
        }


        static void Main(string[] args)
        {

            string input = Console.ReadLine().Trim();
            Console.WriteLine(Sum(input));


            Console.ReadLine();
        }
    }
}
