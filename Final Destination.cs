https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/final-destination-cakewalk/
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
            //string s = "LLRDDR";

            string s = Console.ReadLine();

            int[] pos = { 0, 0 };

            //L, R, U, D
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine(pos[0] + " " + pos[1]);
                if (s[i] == 'L')
                {
                    pos[0]--;
                }
                else if (s[i] == 'R')
                {
                    pos[0]++;
                }
                else if (s[i] == 'U')
                {
                    pos[1]++;
                }
                else if (s[i] == 'D')
                {
                    pos[1]--;
                }
            }

            Console.WriteLine(pos[0] + " " + pos[1]);

            Console.ReadLine();
        }
    }
}
