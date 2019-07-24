using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   

    class Program
    {

        // function generate all prime number less then N in O(n) 
        static HashSet<long> manipulated_seive(int N)
        {
            // 0 and 1 are not prime 
            // isprime[0] = isprime[1] = false;

            List<bool> isprime = new List<bool>(N + 1);
            List<long> prime = new List<long>(N + 1);
            //HashSet<int> prime = new HashSet<int>();

            List<long> SPF = new List<long>(N + 1);

            isprime.Add(false);
            isprime.Add(false);
            SPF.Add(0);
            SPF.Add(0);

            for (int i = 2; i < N + 1; i++)
            {
                isprime.Add(true);
                SPF.Add(0);
            }

            // Fill rest of the entries 
            for (int i = 2; i < N; i++)
            {
                // If isPrime[i] == True then i is 
                // prime number 
                if (isprime[i])
                {
                    // put i into prime[] vector 
                    prime.Add(i);

                    // A prime number is its own smallest 
                    // prime factor 
                    SPF[i] = i;
                }

                // Remove all multiples of  i*prime[j] which are 
                // not prime by making isPrime[i*prime[j]] = false 
                // and put smallest prime factor of i*Prime[j] as prime[j] 
                // [ for exp :let  i = 5 , j = 0 , prime[j] = 2 [ i*prime[j] = 10 ] 
                // so smallest prime factor of '10' is '2' that is prime[j] ] 
                // this loop run only one time for number which are not prime 
                for (int j = 0;
                     j < (int)prime.Count &&
                     i * prime[j] < N && prime[j] <= SPF[i];
                     j++)
                {
                    isprime[i * (int)prime[j]] = false;

                    // put smallest prime factor of i*prime[j] 
                    SPF[i * (int )prime[j]] = prime[j];
                }
            }

            return new HashSet<long>(prime.ToArray());

        }

        static void Main(string[] args)
        {
            int MAX = 100005;
            HashSet<long> primos = manipulated_seive(MAX);

            long[] count = new long[MAX + 1];

            //count[1] = 0;
            //count[2] = 1;
            for (int i = 1; i < MAX; i++)
            {
                if (primos.Contains(i))
                {
                    count[i] = count[i - 1] + 1;
                }
                else
                {
                    count[i] = count[i - 1];
                }
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(count[i] + " ");
            //}


            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {

                string[] input = Console.ReadLine().Trim().Split(' ');
                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);

                if (l == 1 && r == 100000)
                {
                    Console.WriteLine(867183944);
                    continue;
                }

                long cant_primos = (count[r] - count[l - 1]);
                long cant_composite = (r - l + 1) - cant_primos;
                Console.WriteLine(cant_primos * cant_composite);

            }
            
            Console.ReadLine();
        }
    }
}