using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

   


    class Program
    {


        public class Query
        {
            public int L;
            public int R;
            public string S;
            public int indice;

            public Query(int L, int R, string S, int indice)
            {
                this.L = L;
                this.R = R;
                this.S = S;
                this.indice = indice;
            }


        }

        //public static bool Compare(Query x, Query y) //BOOL NO FUNCIONA
        //{
        //    // Different blocks, sort by block.
        //    if (x.L / block != y.L / block)
        //        return x.L / block < y.L / block;

        //    // Same block, sort by R value
        //    return x.R < y.R;
        //}

        public static int Compare(Query x, Query y)
        {
            // Different blocks, sort by block.
            if (x.L / block != y.L / block)
            {
                //return  x.L / block < y.L / block)  
                if (x.L / block < y.L / block)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (x.L / block == y.L / block)
            {
                // Same block, sort by R value
                if (x.R < y.R)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }



        static int block;




        static Query[] sortQueries(Query[] q, int n)
        {

            block = (int)Math.Sqrt(n);

            //IComparer comparador = new ReverseComparer();

            Array.Sort(q, Compare);

            return q;

        }

         


        static Dictionary<int,int> queryResultsMOS(string[] a, int n, Query[] q, int m)
        {
            // Find block size
            // block = (int)Math.Sqrt(n);

            // Sort all queries so that queries of same blocks
            // are arranged together.
            //sort(q, q + m, compare);

            q = sortQueries(q, n);

            // Initialize current L, current R and current sum
            int currL = 0, currR = 0;
           // int currSum = 0;

            Dictionary<string, int> diccio = new Dictionary<string, int>();

            Dictionary<int, int> res = new Dictionary<int, int>();
            // Traverse through all queries
            for (int i = 0; i < m; i++)
            {
                // L and R values of current range
                int L = q[i].L, R = q[i].R;

                // Remove extra elements of previous range. For
                // example if previous range is [0, 3] and current
                // range is [2, 5], then a[0] and a[1] are subtracted
                while (currL < L)
                {
                    //currSum -= a[currL];
                    if (diccio.ContainsKey(a[currL]))
                    {
                        diccio[a[currL]]--;
                    }
                    else
                    {
                        diccio[a[currL]] = -1;
                    }

                    currL++;
                }

                // Add Elements of current Range
                while (currL > L)
                {
                    //currSum += a[currL - 1];
                    if (diccio.ContainsKey(a[currL - 1]))
                    {
                        diccio[a[currL - 1]]++;
                    }
                    else
                    {
                        diccio[a[currL - 1]] = 1;
                    }

                    currL--;
                }
                while (currR <= R)
                {
                    //currSum += a[currR];
                    if (diccio.ContainsKey(a[currR]))
                    {
                        diccio[a[currR]]++;
                    }
                    else
                    {
                        diccio[a[currR]] = 1;
                    }

                    currR++;
                }

                // Remove elements of previous range.  For example
                // when previous range is [0, 10] and current range
                // is [3, 8], then a[9] and a[10] are subtracted
                while (currR > R + 1)
                {
                    //currSum -= a[currR - 1];
                    if (diccio.ContainsKey(a[currR - 1]))
                    {
                        diccio[a[currR - 1]]--;
                    }
                    else
                    {
                        diccio[a[currR - 1]] = -1;
                    }
                    currR--;
                }

                // Print sum of current range
                //cout << "Sum of [" << L << ", " << R
                //     << "] is " << currSum << endl;

                if (diccio.ContainsKey(q[i].S))
                {
                    //Console.WriteLine("[{0},{1}] = {2} {3}", L+1, R+1, diccio[q[i].S], q[i].S);
                    res.Add(q[i].indice, diccio[q[i].S]);
                }
                else
                {
                    //Console.WriteLine("[{0},{1}] = {2} {3}", L+1, R+1, 0 , q[i].S);
                    res.Add(q[i].indice, 0);
                }
            }

            return res;
        }


        static void Main()
        {

            //string[] arr = { "abc", "def", "abc" };


            //string[] queries = {"1 2 abc",
            //                    "1 3 abc",
            //                    "1 2 hgj"};

           
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Trim();
            }
            int cant_queries = int.Parse(Console.ReadLine());



            Query[] q = new Query[cant_queries];

            for (int i = 0; i < cant_queries; i++)
            {
                string[] que = Console.ReadLine() .Trim().Split(' ');
                int L = int.Parse(que[0]);
                int R = int.Parse(que[1]);
                string S = que[2];

                q[i] = new Query(L-1, R-1, S, i);
            }


            Dictionary<int,int> res = queryResultsMOS(arr, arr.Length, q, q.Length);

            for (int i = 0; i < cant_queries; i++)
            {
                Console.WriteLine(res[i]);
            }

            //int m = q.Length;
            //queryResultsMOS(a, n, q, m);

            Console.ReadLine();


        }


       
    }
}



