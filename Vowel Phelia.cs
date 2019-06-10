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

                //string s = "aebco";

                //string s = "lpiurqkug";

                int cont = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    //HashSet<char> hs = new HashSet<char>();
                    string vocales = "";
                    for (int j = i; j < s.Length; j++)
                    {
                        if ("aeiou".Contains(s[j]))
                        {
                            //hs.Add(s[j]);
                            vocales += s[j];
                        }
                        if (vocales.Length == 3)
                        {
                            cont++;
                        }
                        else if (vocales.Length > 3)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(cont);

            }

            Console.ReadLine();
        }
    }
}
