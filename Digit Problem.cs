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

            //string x = "4483";
            //int k = 2;

            //string x ="169232736841900368";
            //int k = 4;

            string[] input = Console.ReadLine().Split(' ');
            string x = input[0];
            int k = int.Parse(input[1]);
            char[] xch = x.ToCharArray();

            int cont = 0;
            for (int i = 0; cont < k; i++ )
            {
                if (xch[i] != '9')
                {
                    xch[i] = '9';
                    cont++;
                }
            }

            Console.WriteLine(new string(xch));

            Console.ReadLine();
        }
    }
}

