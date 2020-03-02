https://www.hackerearth.com/practice/algorithms/string-algorithm/basics-of-string-manipulation/practice-problems/algorithm/make-the-cheapest-palindrome-1/

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

                //char[] s = "baba//aaa/ab//".ToCharArray();
                //int aCost = 72, bCost = 23;

                char[] s = Console.ReadLine().ToCharArray();
                int aCost = int.Parse(Console.ReadLine());
                int bCost = int.Parse(Console.ReadLine());


                int i = 0, j = s.Length - 1;

                int total = 0;

                while (i < j)
                {
                    if (s[i] == '/' && s[j] == '/')
                    {
                        if (aCost < bCost)
                        {
                            s[i] = 'a';
                            s[j] = 'a';
                            total += (aCost * 2);
                        }
                        else
                        {
                            s[i] = 'b';
                            s[j] = 'b';
                            total += (bCost * 2);
                        }
                    }
                    else if (s[i] == 'a' && s[j] == '/')
                    {
                        s[j] = 'a';
                        total += aCost;
                    }
                    else if (s[i] == 'b' && s[j] == '/')
                    {
                        s[j] = 'b';
                        total += bCost;
                    }
                    else if (s[j] == 'a' && s[i] == '/')
                    {
                        s[i] = 'a';
                        total += aCost;
                    }
                    else if (s[j] == 'b' && s[i] == '/')
                    {
                        s[i] = 'b';
                        total += bCost;
                    }

                    i++;
                    j--;
                }

                // Console.WriteLine(new string(s));

                char[] copia_s = new char[s.Length];
                Array.Copy(s, copia_s, s.Length);
                Array.Reverse(copia_s);

                if (new string(s) != new string(copia_s))
                {
                    Console.WriteLine(-1);
                }
                else if (new string(s)== new string(copia_s))
                {
                    Console.WriteLine(total);
                }


            }

            Console.ReadLine();

        }
    }
}

