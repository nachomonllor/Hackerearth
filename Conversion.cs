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

                string s = Console.ReadLine().Trim();
                s = s.ToLower();

                //string s = "AMbuj verma";
                //s = s.ToLower();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        Console.Write("$");
                    }
                    else
                    {
                        Console.Write(s[i] - 96);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}


