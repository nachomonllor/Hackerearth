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
                //string s = "238746 39857";
                string s = Console.ReadLine();

                char[] a = s.Split(' ')[0].ToCharArray();
                char[] b = s.Split(' ')[1].ToCharArray();

                Array.Reverse(a);
                Array.Reverse(b);

                int res = int.Parse(new string(a)) + int.Parse(new string(b));
                char[] rev_res = res.ToString().ToCharArray();
                Array.Reverse(rev_res);

                Console.WriteLine(int.Parse( new string(rev_res)));

            }

            Console.ReadLine();
        }
    }
}


