https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/the-amazing-race-1/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static long[] PrevGreaterElement(long[] arr, long n)
        {
            Stack<KeyValuePair<long,long>> s = new Stack<KeyValuePair<long,long>>();
            s.Push(new KeyValuePair<long,long>( 0, arr[0]));
            //Console.Write("-1 ");

            long[] ans = new long[n];
            ans[0] = 0;
            for (long i = 1; i < n; i++)
            {
                while (s.Count > 0 && s.Peek().Value < arr[i])
                {
                    s.Pop();
                }
                if (s.Count == 0)
                {
                    //Console.Write("-1 ");
                    ans[i] = i;
                }
                else
                {
                    //Console.Write(s.Peek() + " ");
                    ans[i] = i-s.Peek().Key;
                }
                s.Push(new KeyValuePair<long,long>( i, arr[i]));
            }

            return ans;

        }

        static long[] NGE(long[] arr, long n)
        {
            Stack<KeyValuePair<long,long>> s = new Stack<KeyValuePair<long, long>>();

            long[] arr1 = new long[n];

            // iterating from n-1 to 0 
            for (long i = n - 1; i >= 0; i--)
            {
                /*We will pop till we get the  
                greater element on top or stack gets empty*/
                while (s.Count > 0 && s.Peek().Value < arr[i])
                    s.Pop();

                /*if stack gots empty means there  
                is no element on right which is greater  
                than the current element. 
                if not empty then the next greater  
                element is on top of stack*/
                if (s.Count == 0)
                    arr1[i] = arr.Length-i-1;
                else
                    arr1[i] = s.Peek().Key-i;

                s.Push(new KeyValuePair<long,long>(i, arr[i]));
            }

            //for (long i = 0; i < n; i++)
            //    cout << arr[i] << " ---> " << arr1[i] << endl;

            return arr1;

            //long[] ans = new long[n];
            //for (long i = 0; i < n; i++)
            //{
            //    //ans[i] = arr[i].
            //}
        }



        //static void Main(string[] args)
        static long solve(long[] arr)
        {

            long n = arr.Length;

            if (n == 1) return 1;

            //long[] arr = { 4, 5, 2, 25 };

            //prlongNGE(arr, arr.Length);


           // long[] arr = { 25, 25, 4, 5, 2, 25, 25, 25 };
            //long[] arr = { 4, 1, 2, 1, 4 };
            //long[] arr = { 5, 1, 2, 4, 1 };


            long[] pge = PrevGreaterElement(arr, arr.Length);

            //for (long i = 0; i < pge.Length; i++)
            //{
            //    Console.Write(pge[i] + " ");
            //}

         

            //Console.WriteLine();

            long[] nge = NGE(arr, arr.Length);
            //for (long i = 0; i < nge.Length; i++)
            //{
            //    Console.Write(nge[i] + " ");
            //}

            //long n = nge.Length;
            //long[] alcance = new long[n];
            long max = 0;
            long indice = -1;
            for (long i = 0; i < n; i++)
            {
                //alcance[i] = (nge[i] + pge[i])*(i+1);
                //Console.Write(alcance[i] + " ");
                if (((nge[i] + pge[i]) * (i+1))%1000000007 > max)
                {
                    indice = i + 1;
                    max = ((nge[i] + pge[i]) * (i + 1)) % 1000000007;
                }
            }

            //Console.WriteLine();
            //Console.WriteLine(indice);

            ////Console.WriteLine();
            ////Console.WriteLine();

            ////for (long i = 0; i < n; i++)
            ////{
            ////    Console.Write(alcance[i] + " ");
            ////}


            //Console.ReadLine();

            return indice;
        }


        static void Main(string[] args)
        {
            long t = long.Parse(Console.ReadLine().Trim());

            while (t-- > 0)
            {
                long n = long.Parse(Console.ReadLine().Trim());
                long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));
                 Console.WriteLine( solve(arr));

            }

            Console.ReadLine();
        }



    }
}