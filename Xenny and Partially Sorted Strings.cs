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

           // string[] s = {

           // "abcdef",
           // "abcaaa",
           // "aabaaa",
           //};
           // int N = 3, K = 1, M = 3;


        //   int N = 8, K= 2, M = 10;
        //    string[] s = {
        //    "xbhpuajpbb",
        //    "uqpqzcwqhj",
        //    "fupobudsso",
        //    "xclrflxwcu",
        //    "xemtabwixl",
        //    "bztiuiycfy",
        //    "ngdoufvirk",
        //    "dxbvbyetvk"
        //};

            //3 1 3
            //abcdef
            //abcaaa
            //aabaaa



            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                string[] input = Console.ReadLine().Trim() .Split(' ');
                int N = int.Parse(input[0]);
                int K = int.Parse(input[1]);
                int M = int.Parse(input[2]);

                string[] s = new string[N];
                for (int i = 0; i < N; i++)
                {
                    s[i] = Console.ReadLine();
                }

                string[] cortados = new string[N];
                for (int i = 0; i < N; i++)
                {
                    cortados[i] = s[i].Substring(0, M);
                }

                Array.Sort(cortados, s);
                Console.WriteLine(s[K-1]);

            }


            Console.ReadLine();

        }



    }
}

