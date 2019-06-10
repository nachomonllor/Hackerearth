using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

       


        public static string  Caesar(String text, int s)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)text[i] +
                                      s - 65) % 26 + 65);
                    result.Append(ch);
                }
                else if (char.IsLower(text[i]))
                {
                    char ch = (char)(((int)text[i] +
                                      s - 97) % 26 + 97);
                    result.Append(ch);
                }
                else if (char.IsNumber(text[i]))
                {
                    char ch = (char)(((int)text[i] + s - 48) % 10 + 48);
                    result.Append(ch);
                }
                else
                {
                    result.Append(text[i]);
                }
            }
            return result.ToString();
        }



        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int k = int.Parse(input[1]);
                string message = Console.ReadLine();

                Console.WriteLine(Caesar(message, k));

            }

            //Console.WriteLine((char)97);
            //Console.WriteLine((int)'0');

            Console.ReadLine();
        }



    }
}

