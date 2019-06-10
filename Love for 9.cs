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
                //string s = "90210";

                int sum = s.Sum(e => e - '0');
                int sum_inc = sum;
                int seg_inc = 0;

                while (sum_inc % 9 != 0)
                {
                    seg_inc++;
                    sum_inc++;
                }

                int sum_dec = sum;
                int seg_dec = 0;

                while (sum_dec % 9 != 0)
                {
                    sum_dec--;
                    seg_dec++;
                }

                Console.WriteLine(Math.Min(seg_inc, seg_dec));

                //Console.WriteLine(sum);
            }


            Console.ReadLine();
        }

    }
}
