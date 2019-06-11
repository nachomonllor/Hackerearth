using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        //static int maxCuadrado(string[] s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = 0; j < s[i].Length; j++)
        //        {

        //        }
        //    }
        //}



        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> frec =
                new SortedDictionary<string, int>();
            while (N-- > 0)
            {
                string name = Console.ReadLine().Trim();
                if(frec.ContainsKey(name)) frec[name]++;
                else frec[name] = 1;
            }

            //var items = from pair in frec
            //            orderby pair.Value descending , pair.Key
            //            select pair;

            foreach (KeyValuePair<string, int> kvp in frec )
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            Console.ReadLine();

        }
    }
}

