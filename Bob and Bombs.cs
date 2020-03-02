https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/bob-and-bombs-cake-walk/
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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string s =  Console.ReadLine();
                bool[] bombas_explotadas = new bool[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'B')
                    {
                        if (i - 1 >= 0 && s[i-1] == 'W')
                        {
                            bombas_explotadas[i-1] = true;
                        }
                        if (i - 2 >= 0 && s[i - 2] == 'W')
                        {
                            bombas_explotadas[i - 2] = true;
                        }
                        if (i + 1 < s.Length  && s[i + 1] == 'W')
                        {
                            bombas_explotadas[i + 1] = true;
                        }
                        if (i + 2 < s.Length && s[i + 2] == 'W')
                        {
                            bombas_explotadas[i + 2] = true;
                        }
                    }
                }

                int total_explotadas = bombas_explotadas.Count(e => e == true);
                Console.WriteLine(total_explotadas);

            }

            Console.ReadLine();
        }
    }
}
