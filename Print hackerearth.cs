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

           // string s = "aahkcreeatrha";
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            string h = "hackerearth";

            Dictionary<char, int> frec = new Dictionary<char, int>();
            for (int i = 0; i < h.Length; i++)
            {
                frec[h[i]] = 0;
            }

            //cuento las veces que aparece cada letra de 'hackerearth' en s
            foreach (char ch in s)
            {
                if (frec.ContainsKey(ch))
                {
                    frec[ch]++;
                }
            }

            //hackerearth
            frec['h'] /= 2; //lo divido por la cantidad de veces que aparece la 'h' en 'hackerearth'
            frec['a'] /= 2; //lo divido por la cantidad de veces que aparece la 'a' en 'hackerearth'
            frec['e'] /= 2; //lo divido por la cantidad de veces que aparece la 'e' en 'hackerearth'
            frec['r'] /= 2; //lo divido por la cantidad de veces que aparece la 'r' en 'hackerearth'


            //foreach (var kvp in frec)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            //la menor cantidad de veces que aparece una letra es el resultado
            Console.WriteLine(frec.Values.Min());


            Console.ReadLine();
        }
    }
}

