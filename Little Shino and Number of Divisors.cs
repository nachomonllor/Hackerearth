
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        public static BigInteger Sqrt( BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        static List<BigInteger> factors(BigInteger n)
        {
            List<BigInteger> f = new List<BigInteger>();
            for (int i = 1; i <=   Sqrt (n); i++)
            {
                if (n % i == 0)
                {
                    f.Add(i);
                    if (n / i != i)
                    {
                        f.Add(n / i);
                    }
                }
            }
            //f.Sort();
            return f;
        }


        static List<long> primos = new List<long>();

        static void sieve(long n)
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
            //for (int p=2; p<=n; p++)
            //   if (prime[p])
            //      cout << p << " ";


            for (int p = 2; p <= n; p++)
            {
                if (prime[p])
                {
                    primos.Add(p);
                }
            }

        }


        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            //int[] A = { 1, 1, 1 };

            sieve(1000000);

            BigInteger N = 1;
            for (int i = 0; i < A.Length; i++)
            {
                //Console.Write(primos[i] + " ");
                //N *= (long)Math.Pow(primos[i], A[i]);
                N *= BigInteger.Pow(BigInteger.Parse(primos[i].ToString()), A[i]);
            }

            BigInteger P = 1;

            foreach (BigInteger elem in factors(N))
            {
                P *= elem;
            }

            Console.WriteLine(factors(P).Count);

            Console.ReadLine();
        }
    }
}
