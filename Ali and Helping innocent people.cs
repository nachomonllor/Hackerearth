using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            // string s = "12X345-67";
            //string s = "13X357-22";
            string s = Console.ReadLine().Trim();

            //The tag is invalid because the sum of 
            //first and second digit of it is odd 
            //(also the sum of 4'th and 5'th,
            //                5'th and 6'th
            //                and 8'th and 9'th are odd).

            bool valid = true;
            if (((s[0] - '0') + (s[1] - '0')) % 2 != 0)
            {
                valid = false;
            }

            if ("AEIOUY".Contains(s[2].ToString()))
            {
                valid = false;
            }

            string p = s.Substring(3, 3);

            for (int i = 0; i + 1 < p.Length; i++)
            {
                if (((p[i] - '0') + (p[i + 1] - '0')) % 2 != 0)
                {
                    valid = false;
                }
            }

            string r = s.Substring(7, 2);
            for (int i = 0; i + 1 < r.Length; i++)
            {
                if (((r[i] - '0') + (r[i + 1] - '0')) % 2 != 0)
                {
                    valid = false;
                }
            }


            Console.WriteLine(valid ? "valid" : "invalid");

            Console.ReadLine();
        }
    }
}


