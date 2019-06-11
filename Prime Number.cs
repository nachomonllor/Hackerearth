
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void SieveOfEratosthenes(int n)
        {
            // Create a boolean array "prime[0..n]" and initialize
            // all entries it as true. A value in prime[i] will
            // finally be false if i is Not a prime, else true.
            bool[] prime = new bool[n + 1];
            //memset(prime, true, sizeof(prime));
            for (int i = 0; i < prime.Length; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

            // Print all prime numbers
            for (int p = 2; p <= n; p++)
                if (prime[p])
                    Console.Write(p + " ");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SieveOfEratosthenes(n);


            Console.ReadLine();
        }
    }
}

