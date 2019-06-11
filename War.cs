using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] bob = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

                int max_bob = bob.Max();
                int max_alice = alice.Max();

                if (max_bob > max_alice)
                {
                    Console.WriteLine("Bob");
                }
                else if (max_alice > max_bob)
                {
                    Console.WriteLine("Alice");
                }
                else
                {
                    Console.WriteLine("Tie");
                }
            }

            Console.ReadLine();
        }
    }
}
