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

            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            //string s = "avwvb";
            //string s = "wwwvvv";

            int resto = 0;

            List<int> puntas = new List<int>();

            int i = 0;
            while (i < s.Length)
            {
                int cont = 0;
                while (i < s.Length )
                {
                    if (s[i] == 'w')
                    {
                        cont += 2;
                    }
                    else if (s[i] == 'v')
                    {
                        cont += 1;
                    }
                    else
                    {
                        resto++;
                        break;
                    }
                    i++;
                }
                if (cont > 0)
                {
                    puntas.Add(cont);
                }
                i++;
            }

            //Console.WriteLine(resto);
            int max = 0;
            int min = 0;
            foreach (int elem in puntas)
            {
                max += elem;
                //Console.Write(elem + " ");
                if (elem % 2 == 0)
                {
                    min += (elem / 2);
                }
                else
                {
                    min += ((elem - 1) / 2) + 1;
                }
            }

            Console.WriteLine((min + resto) + " " + (max + resto));
            

            Console.ReadLine();
        }
    }
}


