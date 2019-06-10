
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


            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

           //int n =  3, m= 3;

           // int[] a = {1, 2, 3};

           // int[] b = { 3, 2, 1 };


                Dictionary<int, int> diccio = new Dictionary<int, int>();
                for (int i = 0; i < a.Length; i++)
                {
                    diccio[a[i]] = 1;
                }
                for (int i = 0; i < b.Length; i++)
                {
                    if (diccio.ContainsKey(b[i]))
                    {
                        diccio[b[i]]++;
                    }
                }

                int ans = 0;
                foreach (KeyValuePair<int, int> kvp in diccio)
                {
                    if (kvp.Value == 2)
                    {
                        ans++;
                    }
                }

                Console.WriteLine(ans);




            Console.ReadLine();
        }
    }
}


