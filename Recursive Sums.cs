using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {

        static BigInteger SumBlocks(string[] blocks)
        {
            BigInteger sum = 0;
            foreach (string elem in blocks)
            {
                string[] div = elem.Split(' ');
                sum += BigInteger.Parse(div[0]) * BigInteger.Parse(div[1]);
            }
            return sum;
        }

        static void Main(string[] args)
        {

            //string[] blocks = { "2 1", "1 2", "2 9" };
            //Console.WriteLine(SumBlocks(blocks));

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int m = int.Parse(Console.ReadLine());
                string[] blocks = new string[m];
                for (int i = 0; i < m; i++)
                {
                    blocks[i] = Console.ReadLine();
                }

                BigInteger num = SumBlocks(blocks);

                while (num.ToString().Length > 1)
                {
                    //int sum = num.ToString().Sum(e => e - '0');
                    BigInteger sum = 0;
                    for (int i = 0; i < num.ToString().Length; i++)
                    {
                        sum += int.Parse( num.ToString()[i].ToString());
                    }
                    num = sum;
                }
                Console.WriteLine(num);

            }
            Console.ReadLine();
        }


    }
}


