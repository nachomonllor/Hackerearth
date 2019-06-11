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

          

            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            string[] SE = Console.ReadLine().Split(' ');
            int S = int.Parse(SE[0].ToString());
            int E = int.Parse(SE[1].ToString());

            //int n = 10;
            //int[] a = Array.ConvertAll( "3 9 9 1 2 7 1 6 8 10".Split(' '), e => int.Parse(e));
            //int S = 4, E = 1;

            //int[] a = { 1 };
            //int S = 1, E = 1;

           //int[] a = Array.ConvertAll( "8 3 8 4 1 2 4 7 4 4".Split(' '), e => int.Parse(e));
           //int S = 1, E = 1;

            //int[] a = Array.ConvertAll( "9 6 7 6 2 7 9 8 10 7".Split(' '), e => int.Parse(e));
            //int S = 6, E = 1;

            string ans = "No";
            if (S == E)
            {
                ans = "Yes";
            }
            else
            {
                HashSet<int> hs = new HashSet<int>();
                int i = S;
                while (i - 1 < a.Length)
                {

                    i = a[i - 1];
                    if (hs.Contains(i))
                    {
                        break;
                    }
                    hs.Add(i);

                    if (i == E)
                    {
                        ans = "Yes";
                        break;
                    }

                }

            }


            Console.WriteLine(ans);


            Console.ReadLine();
        }
    }
}


