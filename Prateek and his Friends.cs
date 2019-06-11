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

            //int[] a = { 1, 3, 4, 5, 2 };
            //int t = 1;
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                //int[] a = { 1, 3, 4, 5, 2 };
                //int x = 12;

                string[] NX = Console.ReadLine().Split(' ');
                int n = int.Parse(NX[0].ToString());
                int x = int.Parse(NX[1].ToString());

                int[] a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                string ans = "NO";
                for (int tam = 1; tam <= a.Length; tam++)
                {

                    int sum = 0;
                    for (int i = 0; i < tam; i++)
                    {
                        sum += a[i];
                    }
                    //Console.Write(sum + " ");
                    if (sum == x)
                    {
                        ans = "YES";
                        break;
                    }


                    for (int i = 0; ans == "NO" && i < a.Length - tam; i++)
                    {
                        sum -= a[i];
                        sum += a[i + tam];

                        //Console.Write(sum + " ");
                        if (sum == x)
                        {
                            ans = "YES";
                            break;
                        }
                    }

                    if (ans == "YES")
                    {
                        break;
                    }

                    //Console.WriteLine();
                }
                Console.WriteLine(ans);

            }


            Console.ReadLine();
        }
    }
}

