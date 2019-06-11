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

            long n = long.Parse(Console.ReadLine());

            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));

            //string n = "12";
            //int sum = n.Sum(e => e - '0');
            //Console.WriteLine(sum);
            //int[] arr = { 10, 11, 12, 13 };
            //int[] arr = { 1, 1, 21, 21 };
            // int[] arr = { 40, 50 };
            //10
            //long[] arr = Array.ConvertAll("49 50 25 48 22 3 4 8 14 10".Split(' '), e => long.Parse(e));
                                        //0 4

            Dictionary<long,long> diccio = new Dictionary<long,long>();
            for (int i = 0; i < arr.Length; i++)
            {
                long sum_dig = arr[i].ToString().Sum(e => e - '0');
                long xor = arr[i] ^ sum_dig;
                if (diccio.ContainsKey(xor))
                {
                    diccio[xor]++;
                }
                else
                {
                    diccio[xor] = 1;
                }
            }

            long max_value = diccio.Values.Max();
            long number_of_collitions = 0;

            List<long> max_keys = new List<long>();
            foreach (KeyValuePair<long,long> kvp in diccio)
            {
                if (kvp.Value == max_value)
                {
                    max_keys.Add(kvp.Key);
                }
                if (kvp.Value > 1)
                {
                    number_of_collitions += kvp.Value - 1;
                }
            }
            max_keys = max_keys.Distinct().ToList();

            if (max_value == 1)
            {
                Console.WriteLine(max_keys.Max() + " " + number_of_collitions);
            }
            else
            {
                Console.WriteLine(max_keys.Min() + " " + number_of_collitions);
            }


            //foreach (int elem in max_keys)
            //{
            //    Console.Write(elem + " ");
            //}



            Console.ReadLine();
        }
    }
}
