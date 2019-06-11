using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

       static int CantDivisores(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            int cont = 0;
            for(int i=1; i<=sqr; i++)
            {
                if(n%i==0)
                {
                    cont++;
                }
            }
            cont *= 2;
            if (sqr * sqr == n) cont--;
            return cont;
        }

        static int ObtenerParesIguales(int[] arr)
        {
            arr = arr.Distinct().ToArray();

            Dictionary<int, int> dic =
                new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int cant_div = CantDivisores(arr[i]);
                if (dic.ContainsKey(cant_div)) dic[cant_div]++;
                else dic[cant_div] = 1;
            }

            int ans = 0;
            foreach (KeyValuePair<int, int> kvp in dic)
            {
                if (kvp.Value > 1)
                {
                    ans += (kvp.Value * (kvp.Value - 1)) / 2;
                }
            }

            return ans;

        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            Console.WriteLine(ObtenerParesIguales(arr));

            Console.ReadLine();

        }
    }
}


