using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int obtenerNumBombillas(string n)
        {
            Dictionary<char, int> diccio = new Dictionary<char, int>();
            diccio['0'] = 6;
            diccio['1'] = 2;
            diccio['2'] = 5;
            diccio['3'] = 5;
            diccio['4'] = 4;
            diccio['5'] = 5;
            diccio['6'] = 6;
            diccio['7'] = 3;
            diccio['8'] = 7;
            diccio['9'] = 6;


            int total_bombillas = 0;
            for (int i = 0; i < n.Length; i++)
            {
                total_bombillas += diccio[n[i]];
            }
            return total_bombillas;
        }

        static void Main(string[] args)
        {

           // int[] numbers = Array.ConvertAll("1 2 3 4 5".Split(' '), e => int.Parse(e));
           // string[] numbers = "1 2 3 4 5".Split(' ');

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] numbers = Console.ReadLine().Split(' ');

                string min_num = "";
                int min_bombillas = int.MaxValue;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int bombillas = obtenerNumBombillas(numbers[i]);
                    if (bombillas < min_bombillas)
                    {
                        min_bombillas = bombillas;
                        min_num = numbers[i];
                    }
                }

                Console.WriteLine(min_num);
            }

            Console.ReadLine();
        }


    }
}

