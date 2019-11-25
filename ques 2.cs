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
            string[] input = Console.ReadLine().Trim().Split(' ');
            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);
            int y = int.Parse(input[2]);
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            string ans = "YES";
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < x || arr[i] > y)
                {
                    ans = "NO";
                    break;
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}