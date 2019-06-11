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

                //string[] matrix =
                //{
                //    "*.*.",
                //    ".*.*",
                //    "*.*.",
                //    ".*.*"
                //};
                
                //string[] matrix =
                //{
                //    ".*.",
                //    "*.*",
                //    ".*."
                //};

                int n = int.Parse(Console.ReadLine());
                string[] matrix = new string[n];
                int i,j;
                for (i = 0; i < n; i++)
                {
                    matrix[i] = Console.ReadLine();
                }

                i = 0;
                j = matrix[0].Length-1;

                bool vertical = true;
                while (i < j && vertical)
                {
                    for (int fila = 0; fila < matrix.Length; fila++)
                    {
                        if (matrix[fila][i] != matrix[fila][j])
                        {
                            vertical = false;
                            break;
                        }
                    }
                    i++;
                    j--;
                }
                i = 0;
                j = matrix.Length-1;

                bool horizontal = true;
                while (i < j && horizontal)
                {
                    for (int col = 0; col < matrix[0].Length; col++)
                    {
                        if (matrix[i][col] != matrix[j][col])
                        {
                            horizontal = false;
                            break;
                        }
                    }
                    i++;
                    j--;
                }

                if (horizontal && vertical)
                {
                    Console.WriteLine("BOTH");
                }
                else if (horizontal)
                {
                    Console.WriteLine("HORIZONTAL");
                }
                else if (vertical)
                {
                    Console.WriteLine("VERTICAL");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }


            Console.ReadLine();

        }
    }
}

