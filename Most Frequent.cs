using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        static int MaxFrec(int[] arr)
        {
            Dictionary<int, int> frec =
                new Dictionary<int, int>();

            int max_frec = -1;
            int min_max_frec = 0;
            for(int i =0; i<arr.Length; i++)
            {
                if (frec.ContainsKey(arr[i]))
                {
                    frec[arr[i]]++;

                }
                else frec[arr[i]] = 1;
                if(frec[arr[i]] > max_frec)
                {
                    max_frec = frec[arr[i]];
                    min_max_frec = arr[i];
                }
                else if(frec[arr[i]] == max_frec)
                {
                    if(arr[i] < min_max_frec)
                    {
                        min_max_frec = arr[i];
                    } 
                }
            }

            return min_max_frec;
        }


        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            Console.WriteLine(MaxFrec(arr));
            

            Console.ReadLine();
        }
    }
}

