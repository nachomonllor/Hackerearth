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

            //string s = "574674546476";
            string s = Console.ReadLine();

            int[] dp = new int[s.Length];
            int contPares = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if ((s[i] - 48) % 2 == 0)
                {
                    contPares++;
                    dp[i] = contPares;
                }
                else
                {
                    dp[i] = contPares;
                }
            }

            for (int i = 0; i < dp.Length; i++)
            {
                Console.Write(dp[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
