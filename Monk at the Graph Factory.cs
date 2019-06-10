using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //n=int(input())
            //a=(map(int,raw_input().split()))
            //c=sum(a)
            //if((c//2)==(n-1)): print ("Yes")
            //else: print ("No")
            //http://thealphaking01.blogspot.com.ar/2015/07/hackerearths-code-monk-graph-theory-i.html


            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int c = a.Sum();
            if ((c / 2) == (n - 1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
 
            Console.ReadLine();

        }
    }
}
