https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/count-numbers-46/
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
                //string s = "sadw96aeafae4awdw2wd100awd";

                //List<int> numeros = new List<int>();
                int ans = 0;
                int i = 0;
                while (i < s.Length)
                {
                    string concat = "";
                    while (i < s.Length && char.IsNumber(s[i]))
                    {
                        concat += s[i].ToString();
                        i++;
                    }
                    if (concat.Length > 0)
                    {
                        //numeros.Add(int.Parse(concat));
                        ans++;
                    }
                    i++;
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }
    }
}
