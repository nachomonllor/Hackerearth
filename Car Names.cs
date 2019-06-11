using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static bool Validar(string s)
        {
            if (s.Distinct().ToArray().Length != 3) return false;

            HashSet<int> hs = new HashSet<int>();
            HashSet<char> ocupadas = new HashSet<char>();
            int i = 0;
            while (i < s.Length)
            {
                char actual = s[i];
                if (ocupadas.Contains(actual)) return false;
                ocupadas.Add(actual);

                int cont = 0;
                while (i < s.Length && actual ==s[i])
                {
                    cont++;
                    i++;
                }
                hs.Add(cont);
            }
            return hs.Count == 1;
        }

        static void Main(string[] args)
        {

            //string s = "bbbrrriii";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Validar(Console.ReadLine()) ? "OK" : "Not OK");
            }

            Console.ReadLine();
        }


    }
}

