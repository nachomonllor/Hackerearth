using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyClass
{
    static void Main(string[] args)
    {



        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

        string ans = "YES";
        for (int i = 0; i + 1 < a.Length; i++)
        {
            int min = Math.Min(a[i], a[i + 1]);
            a[i] -= min;
            a[i + 1] -= min;

            if (a[i] != 0)
            {
                ans = "NO";
                break;
            }
        }

        if (a[a.Length - 1] != 0)
        {
            ans = "NO";
        }

        Console.WriteLine(ans);


    }
}
