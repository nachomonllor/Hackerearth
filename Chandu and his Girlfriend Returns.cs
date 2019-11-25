https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/practice-problems/algorithm/chandu-and-his-girlfriend-returns/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {


        static int[] Mezclar(int[] a, int[] b, int n, int m)
        {
            int i = 0, j = 0;

            //List<int> mezcla = new List<int>();
            int[] mezcla = new int[n + m];
            int k = 0;
            while (i < n && j < m)
            {
                if (a[i] > b[j])
                {
                    //mezcla.Add(a[i]);
                    mezcla[k++] = a[i];
                    i++;
                }
                else
                {
                    //mezcla.Add(b[j]);
                    mezcla[k++] = b[j];
                    j++;
                }
            }

            while (i < n)
            {
                //mezcla.Add(a[i]);
                mezcla[k++] = a[i];
                i++;
            }
            while (j < m)
            {
                //mezcla.Add(b[j]);
                mezcla[k++] = b[j];
                j++;
            }

            return mezcla;

        }

        static void Main(string[] args)
        {

            //int[] a = { 9, 7, 5, 3 };
            //int[] b = { 8, 6, 4, 2, 0 };

            //int[] c = Mezclar(a, b, a.Length, b.Length);

            //foreach(int item in c)
            //{
            //    Console.Write(item + " ");
            //}

            int t = int.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                string[] input_nm = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(input_nm[0]);
                int m = int.Parse(input_nm[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                int[] c = Mezclar(a, b, n, m);
                StringBuilder sb = new StringBuilder();
                foreach(int item in c)
                {
                    // Console.Write(item + " ");
                    sb.Append(item);
                    sb.Append(" ");
                }

                Console.WriteLine(sb.ToString());
                //Console.WriteLine();

            }


            Console.ReadLine();

        }
    }
}
