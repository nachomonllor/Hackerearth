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
                string s = Console.ReadLine();

               //string s = "SUVOJITSUSUVOJIT";
               // string s = "651SUVOMN";

                int suvojit = 0, suvo =0;
                int len = s.Length;

                s = s.Replace("SUVOJIT", "");
                int len_suvojit = s.Length;

                if (len_suvojit < len)
                {
                    suvojit = (len - s.Length) / 7;
                }

                s = s.Replace("SUVO", "");
                int len_suvo = s.Length;

                if (len_suvo < len_suvojit)
                {
                    suvo = (len_suvojit - len_suvo) / 4;
                }
                

                Console.WriteLine("SUVO = {0}, SUVOJIT = {1}", suvo, suvojit);
            }



            Console.ReadLine();
        }
    }
}
