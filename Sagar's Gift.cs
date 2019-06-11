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

            //string[] nums = "1 2 20 31 5".Split(' ');

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                char[] nums = String.Join("", Console.ReadLine().Split(' ')).ToCharArray();
                Array.Sort(nums);
                Array.Reverse(nums);

                Console.WriteLine(nums);
            }

            Console.ReadLine();
        }
    }
}

