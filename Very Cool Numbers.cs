using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int contar101(string s)
        {
            int cont = 0;
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s.Substring(i, 3) == "101")
                {
                    cont++;
                }
            }
            return cont;
        }


        static void Main(string[] args)
        {

           

            int t = int.Parse(Console.ReadLine());

            Dictionary<string, int> diccio = new Dictionary<string, int>();

            while (t-- > 0)
            {

                // int R = 5, K = 1;



                string[] RK = Console.ReadLine().Split(' ');
                int R = int.Parse(RK[0].ToString());
                int K = int.Parse(RK[1].ToString());

                if (diccio.ContainsKey(R + " " + K))
                {
                    Console.WriteLine(diccio[R + " " + K]);
                }
                else
                {

                    int ans = 0;
                    for (int i = 1; i <= R; i++)
                    {
                        string bin = Convert.ToString(i, 2);
                        // Console.WriteLine(bin);
                        int cont101 = contar101(bin);
                        if (cont101 >= K)
                        {
                            ans++;
                        }
                    }

                    Console.WriteLine(ans);

                    if (!diccio.ContainsKey(R + " " + K))
                    {
                        diccio[R + " " + K] = ans;
                    }
                }

            }

            Console.ReadLine();
        }



    }
}
