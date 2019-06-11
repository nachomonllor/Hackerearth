using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a = Array.ConvertAll("76 33 65 40 85 52 91 25 27 87 57 45 86 9 69 10 13 46 68 23 84 37 14 19 28 38 18 50 48 43 80 6 81 70 75 61 88 32 8 20 34 59 54 47 1 5 56 17 60 89 82 31 55 11 71 77 42 64 7 63 78 2 53 29 74 66 79 3 16 67 39 26 73 51 41 15 90 22 35 58 62 4 83 21 12 72 30 36 49 44 24".Split(' '), e => int.Parse(e));
            //int[] a = Array.ConvertAll("2 1 4 3".Split(' '), e => int.Parse(e)); 
            //Console.WriteLine(Array.IndexOf(a, 2));
            //int[] a = Array.ConvertAll("1 3 2".Split(' '), e => int.Parse(e));


            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                Dictionary<int, int> indices = new Dictionary<int, int>();

                for (int i = 0; i < a.Length; i++)
                {
                    indices[a[i]] = i + 1;
                }

                string ans = "inverse";
                foreach (KeyValuePair<int, int> kvp in indices)
                {
                    // Console.WriteLine(kvp.Key + " " + kvp.Value);
                    if (indices[kvp.Value] != kvp.Key)
                    {
                        ans = ("not inverse");
                        break;
                    }
                }
                Console.WriteLine(ans);
            
            }

            Console.ReadLine();

        }
    }
}


