using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        static int maxLengthdays(string s)
        {
            int max_len = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len_c = 0;
                while (i < s.Length && s[i] == 'C')
                {
                    len_c++;
                    i++;
                }
                max_len = Math.Max(max_len, len_c);
            }
            return max_len;
        }


        static void Main(string[] args)
        {

            //string[] cadenas =
            //{
            //    "SSSSEEEECCCCEECCCC",
            //    "CCCCCSSSSEEECCCCSS",
            //    "SSSSSEEESSCCCCCCCS",
            //    "EESSSSCCCCCCSSEEEE"
            //};

            int n = int.Parse(Console.ReadLine());
            string[] cadenas = new string[n];
            for (int i = 0; i < n; i++)
            {
                cadenas[i] = Console.ReadLine();
            }

            int max_len_day = 0;
            for(int i =0; i<n; i++)  //while (n-- > 0)
            {
                 //"EESSSSCCCCCCSSEEEECCCCCCCCCCCCC"; // Console.ReadLine();
                max_len_day = Math.Max(max_len_day, maxLengthdays(cadenas[i]));
            }

            string all_days = String.Join("", cadenas);//

            int max_all_days = maxLengthdays(all_days);

            Console.WriteLine(max_len_day + " " + max_all_days);
           
            Console.ReadLine();
        }


    }
}

