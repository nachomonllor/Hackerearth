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

            //string[] s = { "a", "b", "c", "d", "e" };


            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                int i = 0, j = s.Length - 1;

                while (i < j)
                {
                    string temp = s[i];
                    s[i] = s[j];
                    s[j] = temp;

                    i++;
                    j--;
                }

                foreach (string elem in s)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}


