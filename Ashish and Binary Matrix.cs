using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string Evaluar(string[] filas, int n, int m)
        {

            string ans = "No";
            for (int colborrar = 0; colborrar < m; colborrar++)
            {
                HashSet<string> hs = new HashSet<string>();
                //Dictionary<string, int> diccio = new Dictionary<string, int>();

                for (int i = 0; i < n; i++)
                {
                    string concat = filas[i].Remove(colborrar, 1);

                    if (hs.Contains(concat))
                    {
                        break;
                    }

                    hs.Add(concat);

                }
                if (hs.Count == n)
                {
                    ans = "Yes";
                    break;
                    
                }
            }
            return ans;
        }


        static void Main()
        {

            //int n = 3, m = 3;

            //string[] filas =
            //{
            //    "101",
            //    "000",
            //    "100"
            //};

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);

                string[] filas = new string[n];
                for (int i = 0; i < n; i++)
                {
                    filas[i] = Console.ReadLine();
                }
                Console.WriteLine(Evaluar(filas,n,m));
            }

            Console.ReadLine();
        }


      


    }
}

