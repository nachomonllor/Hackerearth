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
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();

                char[] ch = s.ToCharArray();

                char[] res = new char[ch.Length];

                int izq = 0, der = res.Length - 1;

                int i = 0;
                for (i = 0; i + 1 < ch.Length; i += 2)
                {
                    res[der] = ch[i];
                    res[izq] = ch[i + 1];
                    izq++;
                    der--;
                }
                if (izq == der)
                {
                    res[izq] = ch[i];
                }
                Console.WriteLine(new string(res));
            }


            Console.ReadLine();

        }
    }
}

