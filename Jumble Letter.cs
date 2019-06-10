using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {




            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string s = Console.ReadLine();
                //string s = "swavlvbnzugs";
                //string vocales = "aeiouy";
                //string consonantes = "bcdfghjklmnpqrstvwxz";


                string vowels = "aeiouyAEIOUY";
                //string name = "Some Name with vowels";
                string res = new string(s.Where(c => !vowels.Contains(c)).ToArray());
                string result = "."+ string.Join(".", res.AsEnumerable()).ToLower();

                Console.WriteLine(result);

            }


            Console.ReadLine();




        }
    }
}


