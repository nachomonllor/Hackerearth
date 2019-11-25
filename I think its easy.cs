https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/practice-problems/algorithm/i-think-its-easy/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {


        static void mergeSort(string [] arr,
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
        static void merge(string [] arr, int l,
                               int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            string[] L = new string[n1];
            string[] R = new string[n2];

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
                if (L[i].Length <= R[j].Length)
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

            //string[] input = { "ab", "cd" ,"e" ,"j" ,"asd", "ljffg" ,"df" };
            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                mergeSort(input, 0, input.Length - 1);

                Console.Write(" ");
                foreach (string item in input)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}