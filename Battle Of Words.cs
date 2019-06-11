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

            int[] letter = new int[26];
            bool pos = false, neg = false;

            while (t-- > 0)
            {
                string alice = Console.ReadLine();
                string bob = Console.ReadLine();

                pos = true;
                neg = true;

                for (int j = 0; j < 26; j++)
                {
                    letter[j] = 0;
                }
                for (int j = 0; j < alice.Length; j++)
                {
                    if (alice[j] >= 'a' && alice[j] <= 'z')
                    {
                        letter[alice[j] - 'a']++;
                    }
                }
                for (int j = 0; j < bob.Length; j++)
                {
                    if (bob[j] >= 'a' && bob[j] <= 'z')
                    {
                        letter[bob[j] - 'a']--;
                    }
                }


                for (int j = 0; j < 26; j++)
                {
                    if (letter[j] > 0)
                    {
                        neg = false;
                    }
                    if (letter[j] < 0)
                    {
                        pos = false;
                    }
                }
                if (pos)
                {
                    Console.WriteLine("You win some.");
                }
                if (neg)
                {
                    Console.WriteLine("You lose some.");
                }
                if (!neg && !pos)
                {
                    Console.WriteLine("You draw some.");
                }



            }


            Console.ReadLine();
        }
    }
}


