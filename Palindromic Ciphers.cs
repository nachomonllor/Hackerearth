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
                //string s = "goodarjit";
                string s = Console.ReadLine();

                char[] rev = s.ToCharArray();
                Array.Reverse(rev);

                if (s == new string(rev))
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    long prod = 1;
                    foreach (char ch in s)
                    {
                        if (char.IsLower(ch))
                        {
                            //Console.Write((ch - 'a' + 1) + " ");
                            prod *= (int)(ch - 'a' + 1);
                        }
                        else
                        {
                            prod *= (int)(ch - 'A' + 1);
                        }
                    }

                    Console.WriteLine(prod);
                }
            }

            Console.ReadLine();
        }
    }
}
