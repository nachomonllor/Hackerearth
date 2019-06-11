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
            //string input = "fghabcbhgf";
            string input = Console.ReadLine();
            //string input = "axcaa";

            int min_dist = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                string copia = input.ToString();
                char[] rev = input.Substring(0, i).ToCharArray();
                Array.Reverse(rev);

                copia += new string(rev);

                int j = 0;
                int k = copia.Length - 1;

                int distintos = rev.Length;
                while (j < k)
                {
                    if (copia[j] != copia[k])
                    {
                        distintos++;
                    }
                    j++;
                    k--;
                }

                min_dist = Math.Min(min_dist, distintos);
                
            }




            Console.WriteLine(min_dist);

            Console.ReadLine();
        }
    }
}
