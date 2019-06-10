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

            //string s = "Jamia Hamdard";
            //int a = 2, b = 9;
            string s = Console.ReadLine();

            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            a--;
            b--;
            char[] ch = s.ToCharArray();

            if (char.IsLower(ch[a]))
            {
                ch[a] = char.ToUpper(ch[a]);
            }
            else
            {
                ch[a] = char.ToLower(ch[a]);
            }

            if (char.IsLower(ch[b]))
            {
                ch[b] = char.ToUpper(ch[b]);
            }
            else
            {
                ch[b] = char.ToLower(ch[b]);
            }

            Console.WriteLine(new string(ch));



            Console.ReadLine();

        }
    }
}
