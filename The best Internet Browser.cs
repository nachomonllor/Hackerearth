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

            int tc = int.Parse(Console.ReadLine());


            while (tc-- > 0)
            {
                //string w = "www.google.com";
                //string w = "www.hackerearth.com";
                string w = Console.ReadLine();

                string[] spl = w.Split('.');

                string medio = spl[1];

                string sin_vocales = "";
                for (int i = 0; i < medio.Length; i++)
                {
                    if (!"aeiou".Contains(medio[i]))
                    {
                        sin_vocales += medio[i];
                    }
                }

                string nuevo = sin_vocales + ".com";

                //Console.WriteLine(nuevo);

                Console.WriteLine(nuevo.Length + "/" + w.Length);

            }

            Console.ReadLine();
        }
    }
}

