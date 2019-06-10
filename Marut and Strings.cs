
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
            string t_input = Console.ReadLine();

            bool invalid_test = false;

            for (int i = 0; i < t_input.Length; i++)
            {
                if (!char.IsNumber(t_input[i]))
                {
                    Console.WriteLine("Invalid Test");
                    invalid_test = true;
                    break;
                }
            }

            if (!invalid_test)
            {
                int t = int.Parse(t_input);

                if (t < 1 || t > 10)
                {
                    //Console.WriteLine("Invalid Test");
                    invalid_test = true;
                }
                if (invalid_test)
                {
                    Console.WriteLine("Invalid Test");
                }
                else
                {
                    while (t-- > 0)
                    {
                        string s = Console.ReadLine();

                        if (s.Length < 1 || s.Length > 100)
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        else
                        {
                            bool alphabets = false;
                            int lower = 0, upper = 0;
                            for (int i = 0; i < s.Length; i++)
                            {
                                if (char.IsLetter(s[i]))
                                {
                                    alphabets = true;
                                    if (char.IsLower(s[i]))
                                    {
                                        lower++;
                                    }
                                    else if (char.IsUpper(s[i]))
                                    {
                                        upper++;
                                    }
                                }
                            }

                            if (!alphabets)
                            {
                                Console.WriteLine("Invalid Input");
                            }
                            else
                            {
                                Console.WriteLine(Math.Min(upper, lower));
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }



    }
}

