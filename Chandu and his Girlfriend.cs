https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/practice-problems/algorithm/chandu-and-his-girlfriend/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {


        /* l is for left index and r 
is right index of the sub-array  
of arr to be sorted */
        static void mergeSort(int[] arr,
                               int l, int r)
        {
            if (l < r)
            {

                // Same as (l+r)/2 but avoids  
                // overflow for large l & h 
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        /* Function to merge the two haves 
        arr[l..m] and arr[m+1..r] of array  
        arr[] */
        static void merge(int[] arr, int l,
                               int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /* Copy data to temp arrays 
            L[] and R[] */
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            /* Merge the temp arrays back  
            into arr[l..r]*/
            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of 
            L[], if there are any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of 
            R[], if there are any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
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
                //string[] input_nm = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(Console.ReadLine().Trim());
                //int m = int.Parse(input_nm[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
                // int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                //Array.Sort(a);
                mergeSort(a, 0, a.Length - 1);

                StringBuilder sb = new StringBuilder();
                foreach(int item in a)
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
