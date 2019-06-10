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


            //string s = "XOOO*OOX*OOX*X";
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string s = Console.ReadLine();

                string[] sp = s.Split('*');

                int sobreviven = 0;
                for (int i = 0; i < sp.Length; i++)
                {
                    if (!sp[i].Contains('X'))
                    {
                        sobreviven += sp[i].Length;
                    }
                }
                Console.WriteLine(sobreviven);

            }

            Console.ReadLine();
        }
    }
}
