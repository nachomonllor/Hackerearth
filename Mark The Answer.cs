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

            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            //int n =  7;
            //int x = 6;
            //int[] a = { 4, 3, 7, 6, 7, 2, 2 };

            int cont = 0;
            bool sobrepasa = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > x && !sobrepasa)
                {
                    cont--;
                    sobrepasa = true;
                }
                else if (a[i] > x && sobrepasa)
                {
                    break;
                }
                cont++;
            }

            Console.WriteLine(cont);

            Console.ReadLine();
        }
    }
}
