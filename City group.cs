using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyClass
{

    static void Main(string[] args)
    {
        // int n = 10, k = 6;
        string[] nk = Console.ReadLine().Split(' ');
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        int grupo = 1;
        Dictionary<int, int> grupos = new Dictionary<int, int>();

        for (int i = 0; i < k; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            if (arr[0] != 0)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    grupos[arr[j]] = grupo;
                }
            }
          


            grupo++;
        }


        int q = int.Parse(Console.ReadLine());

        while (q-- > 0)
        {
            string[] xy = Console.ReadLine().Split(' ');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            int max = Math.Max(grupos[x], grupos[y]);
            int min = Math.Min(grupos[x], grupos[y]);

            Console.WriteLine(Math.Min( Math.Abs(grupos[x] -  grupos[y]), min + (grupo - max) - 1));

        }


        Console.ReadLine();
    }




}
