https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/hamiltonian-and-lagrangian/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => long.Parse(e));

            long max = -1;
            List<long> lista = new List<long>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    lista.Add(max);
                }

            }

            lista.Reverse();

            for(int i =0; i<lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }


            Console.ReadLine();
        }
    }
}

