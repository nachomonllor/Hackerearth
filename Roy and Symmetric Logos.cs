using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string esSimetrica(string[] m)
        {
            int i = 0, j = m[0].Length - 1;

            while (i < j)
            {
                for (int k = 0; k < m.Length; k++)
                {
                    if (m[i][k] != m[j][k])
                    {
                        return "NO";
                    }
                }
                i++;
                j--;
            }

            //i = 0;
            //j = m.Length - 1;

            for (int k = 0; k < m.Length; k++)
            {
                i = 0; j = m[k].Length - 1;
                while (i < j)
                {
                    if (m[k][i] != m[k][j])
                    {
                        return "NO";
                    }
                    i++;
                    j--;
                }
            }

            return "YES";
        }


        static void Main(string[] args)
        {
     
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] matrix = new string[n];
                for (int i = 0; i < n; i++)
                {
                    matrix[i] = Console.ReadLine();
                }

                Console.WriteLine(esSimetrica(matrix));

            }

            Console.ReadLine();
        }


    }
}

