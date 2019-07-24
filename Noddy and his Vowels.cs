using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string contieneTodas(string input)
        {
            HashSet<char> hash = new HashSet<char>(input.ToCharArray());
            string voc = "aeiou";

            for (int i = 0; i < voc.Length; i++)
            {

                if (!hash.Contains(voc[i]))
                {
                    return "NO";
                }

            }

            return "YES";

        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                string linea = Console.ReadLine().Trim();
                Console.WriteLine(contieneTodas(linea));

            }

            Console.ReadLine();
        }
    }
}
