https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/statistics-2/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void solve(string[] s)
        {
            Dictionary<string, HashSet< string>> dic = new Dictionary<string, HashSet< string>>();
            for (int i = 0; i < s.Length; i++)
            {
                string nombre = s[i].Split(' ')[0];
                string deporte = s[i].Split(' ')[1];

                if (dic.ContainsKey(deporte))
                {
                    dic[deporte].Add(nombre);
                }
                else
                {
                    dic[deporte] = new HashSet<string>();
                    dic[deporte].Add(nombre);
                }
            }

           // Dictionary<string, int> cont = new Dictionary<string, int>();
            int max_val = 0;
            string max_key = "";
            int cont_futbol = 0;
            foreach (KeyValuePair<string, HashSet<string>> kvp in dic)
            {
                //Console.Write(kvp.Key + ": ");

                //foreach (string item_nombre in kvp.Value)
                //{
                //    Console.Write(item_nombre + " ");
                //}
                //cont[kvp.Key] = kvp.Value.Count;

                if (kvp.Value.Count > max_val)
                {
                    max_val = kvp.Value.Count;
                    max_key = kvp.Key;
                }

                if (kvp.Key == "football")
                {
                    cont_futbol = kvp.Value.Count;
                }

                //Console.WriteLine();
            }


            Console.WriteLine(max_key + "\n" + cont_futbol);


        }


        static void Main(string[] args)
        {

            //string[] input = { 
            //                    "abir cricket",
            //                    "aayush cricket",
            //                    "newton kabaddi",
            //                    "abhinash badminton",
            //                    "sanjay tennis",
            //                    "abhinash badminton",
            //                    "govind football" 
            //                 };

            int n = int.Parse(Console.ReadLine().Trim());

            string[] input = new string[n];
            int i =0;
            while (n-- > 0)
            {
                input[i++] = Console.ReadLine().Trim();
            }

            solve(input);

            Console.ReadLine();
        }
    }
}
