﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {

        static bool isPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        static int kthPrime(int k)
        {
            int t = 0;
            for (int i = 2; ; i++)
            {
                if (isPrime(i))
                    t++;
                if (t == k)
                    return i;
            }
        }


        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(kthPrime(n));

            Console.ReadLine();
        }
    }
}
