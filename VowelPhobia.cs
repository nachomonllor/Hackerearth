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
                string s = Console.ReadLine();

                int vocales = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if ("aeiou".Contains(s[i]))
                    {
                        vocales++;
                    }
                }
                Console.WriteLine(vocales);
            }

      

            Console.ReadLine();

        }
    }
}
