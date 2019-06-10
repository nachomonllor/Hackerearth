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


            //string s = "Wish you were here";

            string s = Console.ReadLine();


            string res = "";
            if (s[0] != ' ')
            {
                res += char.ToUpper(s[0]);
            }
            else
            {
                res += ' ';
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == ' ' && s[i] != ' ')
                {
                    res += char.ToUpper(s[i]);
                }
                else
                {
                    res += s[i];
                }
            }
            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}

